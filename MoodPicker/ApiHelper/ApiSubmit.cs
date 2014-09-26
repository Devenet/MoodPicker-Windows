
namespace MoodPicker.ApiHelper
{
    class ApiSubmit
    {
        public string token { get; set; }
        public int mood { get; set; }

        public ApiSubmit(string token, int mood)
        {
            this.mood = mood;
            this.token = token;
        }
    }
}
