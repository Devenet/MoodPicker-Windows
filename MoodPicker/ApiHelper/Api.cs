using MoodPicker.Tools;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodPicker.ApiHelper
{
    class Api
    {
        private string server, key, token;
        public string Server { get { return server; } }
        public string Key { get { return key; } }
        public string Token { get { return token; } }
        
        private HttpClient client = new HttpClient();

        public const string JSON_TYPE = "application/json";
        public const string DETAILS_PAGE = "details";

        protected const string VERSION = "api/v1/version";
        protected const string TRANSLATION = "api/v1/translation";
        protected const string AUTHENTIFICATION = "api/v1/authentification";
        protected const string TOKEN = "api/v1/token";
        protected const string DAY_REVIEW = "api/v1/day";
        protected const string FULL_DAY_REVIEW = "api/v1/day/{0}-{1}-{2}";
        protected const string MONTH_REVIEW = "api/v1/month";
        protected const string FULL_MONTH_REVIEW = "api/v1/month/{0}-{1}";
        protected const string YEAR_REVIEW = "api/v1/year";
        protected const string FULL_YEAR_REVIEW = "api/v1/year/{0}";
        protected const string SUBMIT = "api/v1/submit";

        public Api(string server, string key, string token)
        {
            this.server = (server == null || server == String.Empty) ? server : (Regex.Replace(server, @"/\d*$", "") + "/");
            this.key = key;
            this.token = token;

            if (this.CheckUri())
                this.client.BaseAddress = new Uri(this.server);
        }

        static public bool CheckUri(string server)
        {
            if (server == null || server == String.Empty) { return false; }
            Uri result;
            if (!Uri.TryCreate(server, UriKind.Absolute, out result)) { return false; }
            return result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps;
        }

        static public bool IsConnected()
        {
            return new Api(Properties.Settings.Default.API_Server,
                Properties.Settings.Default.API_Key,
                Properties.Settings.Default.API_Token).CheckApi();
        }

        static public bool IsAuthentificated()
        {
            Api api = new Api(Properties.Settings.Default.API_Server,
                Properties.Settings.Default.API_Key,
                Properties.Settings.Default.API_Token);
            try
            {
                return api.CheckApi() && api.GetAuthentificated();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CheckUri()
        {
            return CheckUri(this.server);
        }

        public bool CheckServer()
        {
            if (!this.CheckUri()) { return false; }

            try
            {
                HttpResponseMessage response = this.client.GetAsync("").Result;
                return response.Content.Headers.ContentLength > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CheckApi()
        {
            if (! this.CheckUri()) { return false; }

            try
            {
                HttpResponseMessage response = this.client.GetAsync(VERSION).Result;
                response.EnsureSuccessStatusCode();

                return JsonConvert.DeserializeObject<ApiVersion>(response.Content.ReadAsStringAsync().Result).api_version != null;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ApiVersion GetVersion()
        {
            HttpResponseMessage response = this.client.GetAsync(VERSION).Result;
            if (!response.IsSuccessStatusCode)
            {
                ApiError error = JsonConvert.DeserializeObject<ApiError>(response.Content.ReadAsStringAsync().Result);
                throw new ApiException(error.message, error.error);
            }

            return JsonConvert.DeserializeObject<ApiVersion>(response.Content.ReadAsStringAsync().Result);
        }

        public bool GetAuthentificated()
        {
            try
            {
                HttpResponseMessage response = this.client.PostAsync(
                AUTHENTIFICATION,
                new StringContent(
                    JsonConvert.SerializeObject(new ApiCredentials(this.key, this.token)),
                    Encoding.UTF8, JSON_TYPE)
                ).Result;
                response.EnsureSuccessStatusCode();
                return JsonConvert.DeserializeObject<ApiAuthentification>(response.Content.ReadAsStringAsync().Result).authentification;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ApiToken GetToken()
        {
            Logger.Log("GetToken() loaded");

            HttpResponseMessage response = this.client.PostAsync(
                TOKEN,
                new StringContent(
                    JsonConvert.SerializeObject(new ApiCredentials(this.key, this.token)),
                    Encoding.UTF8, JSON_TYPE)
                ).Result;
            if (!response.IsSuccessStatusCode)
            {
                ApiError error = JsonConvert.DeserializeObject<ApiError>(response.Content.ReadAsStringAsync().Result);
                throw new ApiException(error.message, error.error);
            }

            ApiToken token = JsonConvert.DeserializeObject<ApiToken>(response.Content.ReadAsStringAsync().Result);
            Logger.Log(String.Format("Token {0} expire on {1}", token.token, Helper.TimestampToDate(token.expire).ToLongTimeString()));

            return token;
        }

        public ApiMoods GetMoods(string date)
        {
            string[] dates = date.Split('-');
            HttpResponseMessage response;

            switch (dates.Length)
            {
                case 3:
                    response = this.client.GetAsync(String.Format(FULL_DAY_REVIEW, dates)).Result;
                    break;

                case 2:
                    response = this.client.GetAsync(String.Format(FULL_MONTH_REVIEW, dates)).Result;
                    break;

                case 1:
                    response = this.client.GetAsync(String.Format(FULL_YEAR_REVIEW, dates)).Result;
                    break;

                default:
                    throw new Exception("The given Date is invalid.");
            }

            if (!response.IsSuccessStatusCode)
            {
                ApiError error = JsonConvert.DeserializeObject<ApiError>(response.Content.ReadAsStringAsync().Result);
                throw new ApiException(error.message, error.error);
            }

            ApiMoods moods = JsonConvert.DeserializeObject<ApiMoods>(response.Content.ReadAsStringAsync().Result);
            return moods;
        }

        public ApiMood SubmitMood(int mood)
        {
            ApiToken token = this.GetToken();
            return this.SubmitMood(mood, token);
        }
        public ApiMood SubmitMood(int mood, ApiToken token)
        {
            HttpResponseMessage response = this.client.PostAsync(
                SUBMIT,
                new StringContent(
                    JsonConvert.SerializeObject(new ApiSubmit(token.token, mood)),
                    Encoding.UTF8, JSON_TYPE)
                ).Result;
            if (!response.IsSuccessStatusCode)
            {
                ApiError error = JsonConvert.DeserializeObject<ApiError>(response.Content.ReadAsStringAsync().Result);
                throw new ApiException(error.message, error.error);
            }
            return JsonConvert.DeserializeObject<ApiMood>(response.Content.ReadAsStringAsync().Result);
        }

    }
}
