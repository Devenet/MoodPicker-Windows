using MoodPicker.ApiHelper;
using System;

namespace MoodPicker.Tools
{
    abstract class Helper
    {
        static readonly TimeSpan TIME_BEGIN = new TimeSpan(0, 0, 0);
        static public readonly TimeSpan TIME_MIDDLE = new TimeSpan(13, 0, 0);
        static readonly TimeSpan TIME_END = new TimeSpan(23, 59, 59);

        static public DateTime TimestampToDate(int timestamp)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).AddSeconds(timestamp).ToLocalTime();
        }

        static public bool CanSubmitMood()
        {
            DateTime last = Properties.Data.Default.LastSubmit;

            if (DateTime.Now.TimeOfDay > TIME_END || DateTime.Now.TimeOfDay < TIME_BEGIN)
                return false;

            if (last.Month == DateTime.Now.Month && last.Day < DateTime.Now.Day)
                return true;

            if (DateTime.Now.TimeOfDay < TIME_MIDDLE)
                return !(last.TimeOfDay > TIME_BEGIN && last.TimeOfDay < TIME_MIDDLE);
                
            return !(last.TimeOfDay > TIME_MIDDLE && last.TimeOfDay < TIME_END);
                
        }

        static public int[] GetMoodsCount(ApiMoods moods)
        {
            int[] result = new int[2] {0, 0};
            for (int i = 0; i < moods.moods_count; i++)
            {
                if (moods.moods[i].mood == ApiMood.GOOD)
                    result[0]++;
                else
                    result[1]++;
            }
            return result;
        }

    }
}
