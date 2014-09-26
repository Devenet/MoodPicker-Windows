using MoodPicker.ApiHelper;
using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;

namespace MoodPicker.Box
{
    public partial class ConnectionTestBox : Form
    {

        private const int steps = 10;
        private Api api;

        public ConnectionTestBox(string server, string key, string token)
        {
            InitializeComponent();

            if (server == null || server == String.Empty)
            {
                MessageBox.Show("The server URL is empty.", "Holy crap!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                this.api = new Api(server, key, token);

                closeButton.Enabled = false;
                this.Show();
                TestConnection();

                closeButton.Enabled = true;
            }
        }


        private void TestConnection()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                Title("Checking URL...");
                Historize("Checking URL...", 1);
                if (!api.CheckUri())
                    throw new Exception(String.Format("The URL '{0}' is not valid.", api.Server));
                Historize(String.Format("The URL '{0}' is valid.", api.Server), 2);

                Title("Checking connection to server...");
                Historize("Checking connection to server...", 3);
                if (!api.CheckServer())
                    throw new Exception(String.Format("The server '{0}' is not responding.", new Uri(api.Server).DnsSafeHost));
                Historize(String.Format("The server '{0}' is responding.", new Uri(api.Server).DnsSafeHost), 4);

                Title("Checking API connection...");
                Historize("Checking API connection...", 5);
                if (!api.CheckApi())
                    throw new Exception("Unable to get connected to the API.");
                Historize("The API is responding.", 6);

                Title("Checking API version...");
                Historize("Checking API version...", 7);
                try
                {
                    Historize(String.Format("The API works under version {0}.", api.GetVersion().api_version), 8);
                }
                catch (ApiException ex)
                {
                    throw new Exception(ex.Message);
                }

                Title("Checking API credentials...");
                Historize("Checking API credentials...", 9);
                try
                {
                    Historize(String.Format("Credentials accepted, token {0} recieved.", api.GetToken().token), 10);
                }
                catch (ApiException ex)
                {
                    throw new Exception(String.Format("{0} (Error {1}).", ex.Message, ex.Error));
                }

                stepLabel.ForeColor = Color.Green;
                Title("Successful connection");
                Historize("Successful connection :-)", steps);
            }
            catch (Exception ex)
            {
                stepLabel.ForeColor = Color.Red;
                Title("Connection failed");
                //Historize(ex.Message, (progressBar.Value * steps / 100));
                Historize(ex.Message, steps);
            }
            finally {
                this.Cursor = Cursors.Default;
            }
        }

        private void Historize(string message, int step)
        {
            if (step > 1) { messageTextBox.AppendText(Environment.NewLine); }
            messageTextBox.AppendText(message);
            progressBar.Value = (int)step * 100 / steps;
        }


        private void Title(string message)
        {
            stepLabel.Text = message;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
