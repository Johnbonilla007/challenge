using ChallengeClientForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ChallengeClientForm
{
    public partial class Review : Form
    {
        private int _imageNumber = 1;
        private readonly string _defaultNote = "Add note here...(Ctrl)";

        public Review()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(richTextBoxNotes.Text))
            {
                richTextBoxNotes.Text = _defaultNote;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //Method for Detect shorcut
        protected override bool ProcessDialogKey(Keys keyData)
        {
            #region Detecting shortcuts

            if (keyData == Keys.Escape)
            {
                System.Windows.Forms.Application.Exit();
                return true;
            }

            if (keyData == Keys.F1)
            {
                HandleOnChangeCheckBoxes(checkBoxSealPresent);
                return true;
            }

            if (keyData == Keys.F2)
            {
                HandleOnChangeCheckBoxes(checkBoxHazards);
                return true;
            }

            if (keyData == Keys.F3)
            {
                HandleOnChangeCheckBoxes(checkBoxDamagesFound);
                return true;
            }

            if (keyData == Keys.F6)
            {
                DecreseadSpeed();
                return true;
            }

            if (keyData == Keys.F7)
            {
                if (timer.Enabled)
                {
                    PauseImage();
                    return true;
                }

                PlayImage();
            }

            if (keyData == Keys.F9)
            {
                IncreseadSpeed();
                return true;
            }

            if (keyData == Keys.F10)
            {
                SubmitReview();
                return true;
            }

            if (keyData.CompareTo(Keys.Control) == 1)
            {
                FocusTextBoxNote();
            }

            return base.ProcessDialogKey(keyData);

            #endregion Detecting shortcuts
        }

        private void FocusTextBoxNote()
        {
            richTextBoxNotes.Focus();
        }

        //Method for load image dynamic
        private void LoadImageContinues()
        {
            if (_imageNumber == 5)
            {
                _imageNumber = 1;
            }

            slidePicture.ImageLocation = string.Format(@"Images\{0}.JPG", _imageNumber);
            ShowImageZoom();
            _imageNumber++;
        }

        //Method for show image with zoom
        private void ShowImageZoom()
        {
            pictureBoxZoom.Image = slidePicture.Image;
            pictureBoxZoom.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxZoom.Visible = true;
        }

        //Method for continue play images
        private void PlayImage()
        {
            timer.Enabled = true;
        }

        //Method for continue pause images
        private void PauseImage()
        {
            timer.Enabled = false;
        }

        //Method for change property checked of the checkboxes
        private void HandleOnChangeCheckBoxes(CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                checkBox.Checked = false;
                return;
            }
            checkBox.Checked = true;
        }

        //Here call to restApi to saveReview
        private async void SubmitReview()
        {
            ShowProgressBarIndicator(10);
            ReviewRequest review = MaterializeReview();

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:55558/api/v1/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            ShowProgressBarIndicator(50);

            var response = await client.PostAsJsonAsync("reviews", review);
            var data = await response.Content.ReadAsAsync<ReviewDto>();
            ShowProgressBarIndicator(100);

            if (!string.IsNullOrEmpty(data.Message))
            {
                MessageBox.Show(data.Message, "Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HideProgressBarIndicator();
            }
        }

        //Method for Hide ProgressBar
        private void HideProgressBarIndicator()
        {
            progressBarIndicator.Visible = false;
        }

        //Method for Hide ProgressBar
        private void ShowProgressBarIndicator(int value)
        {
            if (!progressBarIndicator.Visible)
            {
                progressBarIndicator.Show();
            }
            progressBarIndicator.Value = value;
        }

        //Get reques to send to restApi
        private ReviewRequest MaterializeReview()
        {
            return new ReviewRequest
            {
                IsSealPresent = checkBoxSealPresent.Checked,
                IsHazard = checkBoxHazards.Checked,
                IsDamaggeFound = checkBoxDamagesFound.Checked,
                Note = richTextBoxNotes.Text
            };
        }

        //Action Timer for each interval time
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadImageContinues();
        }

        //Method for decrese speed animation of images
        private void DecreseadSpeed()
        {
            timer.Interval = 5000;
        }

        //Method for increase speed animation of images
        private void IncreseadSpeed()
        {
            timer.Interval = 1000;
        }

        //Handler button play
        private void OnHandlePlayImage(object sender, EventArgs e)
        {
            PlayImage();
        }

        //Handler button pause
        private void OnHandlerPauseImage(object sender, EventArgs e)
        {
            PauseImage();
        }

        //Handler button decresead
        private void OnHandlerDecreseadSpeed(object sender, EventArgs e)
        {
            DecreseadSpeed();
        }

        //Handler button submit
        private void HandlerOnSubmit(object sender, EventArgs e)
        {
            SubmitReview();
        }

        //Handler OnLaveTextBoxNote
        private void HandleOnLeaverTextBoxNote(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBoxNotes.Text))
            {
                richTextBoxNotes.Text = "Add note here...(Ctrl+N)";
            }
        }

        //Handler button onClick increase speed
        private void OnHandlerIncreaseSpeed(object sender, EventArgs e)
        {
            IncreseadSpeed();
        }

        //Handler enter textBoxNote
        private void HandleOnEnterTextBoxNote(object sender, EventArgs e)
        {
            if (richTextBoxNotes.Text == _defaultNote)
            {
                richTextBoxNotes.Text = "";
            }
        }
    }
}