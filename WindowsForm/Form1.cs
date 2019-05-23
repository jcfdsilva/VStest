using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

using REST_PrintPayment_G3.Models;
using Newtonsoft.Json;


namespace WindowsForm
{
    public partial class PrintPaymentForm : Form
    {
        private User userQuota = new User("", "", 0);
        public PrintPaymentForm()
        {
            InitializeComponent();
        }

        private void validate_Click(object sender, EventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string uri = "";

                if (int.TryParse(quota.Text, out int n))
                    userQuota.Credit = Convert.ToSingle(quota.Text);
                else
                    user.Text = "error";

                double success = -1;
                bool sent = false;
                if (chooseUidUsername.Text.Equals("Username"))
                {
                    userQuota.Username = user.Text;
                    uri = "http://153.109.124.35:81/rmjsG3-REST/api/users/byusername/";
                    sent = true;
                }
                if (chooseUidUsername.Text.Equals("UserUID"))
                {
                    userQuota.Uid = user.Text;
                    uri = "http://153.109.124.35:81/rmjsG3-REST/api/users/byuid/";
                    sent = true;
                }

                string pro = JsonConvert.SerializeObject(userQuota);

                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                if (sent)
                {
                    var response = httpClient.PutAsync(uri, frame).Result;
                    success = Math.Floor(Convert.ToSingle(response.Content.ReadAsStringAsync().Result));
                }

                if (success != -1)
                {
                    actualQuota.Text = success.ToString();
                }
                else
                {
                    user.Text = "error";
                }
            }

        }


        private void chooseUidUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            getQuota();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            userQuota.Username = Convert.ToString(user.Text);
            if (!chooseUidUsername.Text.Equals("") && chooseUidUsername.Text != null)
                getQuota();
        }

        private void getQuota()
        {
            if (user.Text.Equals("") || user.Text == null)
                return;

            string uriGet;
            double quota = -1;

            if (chooseUidUsername.Text.Equals("Username"))
            {
                uriGet = "http://153.109.124.35:81/rmjsG3-REST/api/users/username/" + userQuota.Username + "/";
                using (HttpClient httpClient = new HttpClient())
                {
                    Task<String> response = httpClient.GetStringAsync(uriGet);
                    quota = Math.Floor(JsonConvert.DeserializeObject<float>(response.Result));
                }

            }


            if (chooseUidUsername.Text.Equals("UserUID"))
            {
                uriGet = "http://153.109.124.35:81/rmjsG3-REST/api/users/uid/" + userQuota.Username;
                using (HttpClient httpClient = new HttpClient())
                {
                    Task<String> response = httpClient.GetStringAsync(uriGet);
                    quota = Math.Floor(JsonConvert.DeserializeObject<float>(response.Result));
                }
            }

            if (quota != -1)
                actualQuota.Text = quota.ToString();
            else
                actualQuota.Text = "";
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            actualQuota.Text = "";
            user.Text = "";
            quota.Text = "";
            chooseUidUsername.Text = "";
        }
    }
}
