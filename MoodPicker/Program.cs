using System;
using System.Threading;
using System.Windows.Forms;

namespace MoodPicker
{
    static class Program
    {

        static Mutex mutex = new Mutex(true, "info.devenet.windows.moodpicker");
        public const string ARGS_INTRAY = "/intray";

        public const string MOODPICKER_WEBSITE = "http://windows.devenet.info/moodpicker";
        public const string MOODPICKER_GITHUB = "https://github.com/nicolabricot/MoodPicker";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MoodPicker moodpicker = new MoodPicker(args);

                if (! (args.Length > 0 && args[0] == ARGS_INTRAY))
                    moodpicker.Show();

                Application.Run();

                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show(
                    "Holy crap, the application is already running.",
                    "Mood Picker",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
