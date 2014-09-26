
namespace MoodPicker.ApiHelper
{
    class ApiCredentials
    {
        public string api_key { get; set; }
        public string api_token { get; set; }

        public ApiCredentials(string key, string token)
        {
            this.api_key = key;
            this.api_token = token;
        }
    }
}
