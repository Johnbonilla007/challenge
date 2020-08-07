using ChallengeClientForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ChallengeClientForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SubmitCredentials();
        }

        private async void SubmitCredentials()
        {
            UserRequest review = MaterializeUser();

            HttpClient client = new HttpClient();

            // Put the following code where you want to initialize the class
            // It can be the static constructor or a one-time initializer
            client.BaseAddress = new Uri("http://localhost:55558/api/v1/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.PostAsJsonAsync("users", review);
            var responseData = await response.Content.ReadAsAsync<ReviewDto>();

            if (!string.IsNullOrEmpty(responseData.Message))
            {
                if (responseData.Message == "Granted Access!")
                {
                    MessageBox.Show(responseData.Message, "Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ShowReviewForm();
                    return;
                }

                MessageBox.Show(responseData.Message, "Response", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowReviewForm()
        {
            new Review().Visible = true;
        }

        private UserRequest MaterializeUser()
        {
            return new UserRequest { UId = textBoxPassWord.Text, Name = textBoxUserName.Text };
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}