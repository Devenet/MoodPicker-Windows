using MoodPicker.Tools;
using System;

namespace MoodPicker.ApiHelper
{
    class ApiMood
    {
        public const int GOOD = 1;
        public const int BAD = -1;

        public int mood { get; set; }
        public int timestamp { get; set; }

        public DateTime Date { get { return Helper.TimestampToDate(this.timestamp); } }

        public string Mood { get { return this.mood == GOOD ? "Good" : "Bad"; } }
    }
}
