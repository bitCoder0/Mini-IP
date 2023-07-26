
/*
 * Mini IP - A simple code to read ip information
 * Code by A.J - RaadRun
 * July 2023
 * Feel free to change and learn :D
 */





namespace MiniIP
{

    using System;
    using System.Diagnostics;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;

    /// <summary>
    /// Manages application main form behaviour
    /// </summary>
    public partial class MainForm : Form
    {

        //---------------API Endpoints---------------//
        string url = "http://ip-api.com/json";
        string urlLineMode = "http://ip-api.com/line";
        string latestIPCache = "NoData";
        string latestJsonCache = "NoData";
        public MainForm()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            changeBackColour();
            await getInfoAndUpdateUIAsync();

        }

        private async void btnCheckIP_Click(object sender, EventArgs e)
        {
            await getInfoAndUpdateUIAsync();

        }
        /// <summary>
        /// changes main form background color to a specific color
        /// </summary>
        void changeBackColour()
        {
            this.BackColor = Color.FromArgb(44, 62, 80);
        }

        /// <summary>
        /// loads data from api and manages UI texts before and after loading
        /// </summary>
        private async Task getInfoAndUpdateUIAsync()
        {
            txtIP.Text = "Loading...";
            txtCountry.Text = "Loading...";
            txtCity.Text = "Loading...";
            txtISP.Text = "Loading...";
            try
            {
                using var httpClient = new HttpClient();

                var response = await httpClient.GetAsync(url);
                try
                {
                    txtIP.Text = "Checking result..";
                    // Ensure that the request was successful - throws exception on fail
                    response.EnsureSuccessStatusCode();
                }
                catch (HttpRequestException exc)
                {
                    txtIP.Text = "Error in getting data:" + exc.Message;
                }
                // Read the JSON data from the response body
                latestJsonCache = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON string into an instance of MyData
                var myData = JsonSerializer.Deserialize<IPAPISchema>(latestJsonCache);

                if (myData != null)
                {
                    txtIP.Text = myData.query;
                    txtCountry.Text = myData.country;
                    txtCity.Text = myData.city;
                    txtISP.Text = myData.isp;

                    latestIPCache = myData.query;
                }
                else
                    txtIP.Text = "There was an error while loading data..";
            }
            catch (Exception err)
            {
                txtIP.Text = "There was an error:" + err.Message;
            }
        }

        /// <summary>
        /// opens api url in web browser using shell execution
        /// </summary>
        private void btnOpenURL_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(urlLineMode) { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        /// <summary>
        /// saves ip in clipboard
        /// called by copy ip button
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(latestIPCache);
        }

        /// <summary>
        /// saves request json in clipboard
        /// called by copy json button
        /// </summary>
        private void btnCopyJson_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(latestJsonCache);
        }

        /// <summary>
        /// opens app info form
        /// </summary>
        private void btnAppInfo_click(object sender, EventArgs e)
        {
            AboutApp aboutForm = (AboutApp)Application.OpenForms["AboutApp"];
            if (aboutForm == null)
            {
                aboutForm = new AboutApp();
                aboutForm.Show();
            }
            else
            {
                aboutForm.Activate();
            }
        }
    }
}
