namespace ChallengeClientForm
{
    partial class Review
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Review));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.checkBoxDamagesFound = new System.Windows.Forms.CheckBox();
            this.checkBoxHazards = new System.Windows.Forms.CheckBox();
            this.checkBoxSealPresent = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBarIndicator = new System.Windows.Forms.ProgressBar();
            this.pictureBoxZoom = new System.Windows.Forms.PictureBox();
            this.slidePicture = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonIncreaseSpeed = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Controls.Add(this.tabPage7);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.HotTrack = true;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(980, 728);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Damage Inspection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBoxNotes);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonSubmit);
            this.panel2.Controls.Add(this.checkBoxDamagesFound);
            this.panel2.Controls.Add(this.checkBoxHazards);
            this.panel2.Controls.Add(this.checkBoxSealPresent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 557);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 140);
            this.panel2.TabIndex = 1;
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.AutoCompleteCustomSource.AddRange(new string[] {
            "fhghfhgfghfhg"});
            this.richTextBoxNotes.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.richTextBoxNotes.Location = new System.Drawing.Point(17, 28);
            this.richTextBoxNotes.Multiline = true;
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(944, 43);
            this.richTextBoxNotes.TabIndex = 9;
            this.richTextBoxNotes.Enter += new System.EventHandler(this.HandleOnEnterTextBoxNote);
            this.richTextBoxNotes.Leave += new System.EventHandler(this.HandleOnLeaverTextBoxNote);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(862, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Break (Esc)";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.buttonIncreaseSpeed);
            this.panel3.Location = new System.Drawing.Point(157, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(699, 46);
            this.panel3.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSubmit.Location = new System.Drawing.Point(28, 77);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(123, 34);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Complete (F10)";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.HandlerOnSubmit);
            // 
            // checkBoxDamagesFound
            // 
            this.checkBoxDamagesFound.AutoSize = true;
            this.checkBoxDamagesFound.Location = new System.Drawing.Point(525, 7);
            this.checkBoxDamagesFound.Name = "checkBoxDamagesFound";
            this.checkBoxDamagesFound.Size = new System.Drawing.Size(143, 17);
            this.checkBoxDamagesFound.TabIndex = 2;
            this.checkBoxDamagesFound.Text = "Damages Found (F3)";
            this.checkBoxDamagesFound.UseVisualStyleBackColor = true;
            // 
            // checkBoxHazards
            // 
            this.checkBoxHazards.AutoSize = true;
            this.checkBoxHazards.Location = new System.Drawing.Point(280, 5);
            this.checkBoxHazards.Name = "checkBoxHazards";
            this.checkBoxHazards.Size = new System.Drawing.Size(98, 17);
            this.checkBoxHazards.TabIndex = 1;
            this.checkBoxHazards.Text = "Hazards (F2)";
            this.checkBoxHazards.UseVisualStyleBackColor = true;
            // 
            // checkBoxSealPresent
            // 
            this.checkBoxSealPresent.AutoSize = true;
            this.checkBoxSealPresent.Location = new System.Drawing.Point(17, 5);
            this.checkBoxSealPresent.Name = "checkBoxSealPresent";
            this.checkBoxSealPresent.Size = new System.Drawing.Size(123, 17);
            this.checkBoxSealPresent.TabIndex = 0;
            this.checkBoxSealPresent.Text = "Seal present (F1)";
            this.checkBoxSealPresent.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBarIndicator);
            this.panel1.Controls.Add(this.pictureBoxZoom);
            this.panel1.Controls.Add(this.slidePicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 694);
            this.panel1.TabIndex = 0;
            // 
            // progressBarIndicator
            // 
            this.progressBarIndicator.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.progressBarIndicator.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarIndicator.Location = new System.Drawing.Point(0, 0);
            this.progressBarIndicator.Name = "progressBarIndicator";
            this.progressBarIndicator.Size = new System.Drawing.Size(964, 23);
            this.progressBarIndicator.TabIndex = 2;
            this.progressBarIndicator.Value = 99;
            this.progressBarIndicator.Visible = false;
            // 
            // pictureBoxZoom
            // 
            this.pictureBoxZoom.Location = new System.Drawing.Point(255, 29);
            this.pictureBoxZoom.Name = "pictureBoxZoom";
            this.pictureBoxZoom.Size = new System.Drawing.Size(447, 508);
            this.pictureBoxZoom.TabIndex = 1;
            this.pictureBoxZoom.TabStop = false;
            this.pictureBoxZoom.Visible = false;
            // 
            // slidePicture
            // 
            this.slidePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slidePicture.Image = ((System.Drawing.Image)(resources.GetObject("slidePicture.Image")));
            this.slidePicture.Location = new System.Drawing.Point(0, 0);
            this.slidePicture.Name = "slidePicture";
            this.slidePicture.Size = new System.Drawing.Size(964, 694);
            this.slidePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slidePicture.TabIndex = 0;
            this.slidePicture.TabStop = false;
            this.slidePicture.WaitOnLoad = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "OCR";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(972, 702);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Empty Inspection";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(972, 702);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Seal Check";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(972, 702);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Genset Check";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(972, 702);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Hazards";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(972, 702);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Ingate";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonIncreaseSpeed
            // 
            this.buttonIncreaseSpeed.Image = ((System.Drawing.Image)(resources.GetObject("buttonIncreaseSpeed.Image")));
            this.buttonIncreaseSpeed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIncreaseSpeed.Location = new System.Drawing.Point(458, 3);
            this.buttonIncreaseSpeed.Name = "buttonIncreaseSpeed";
            this.buttonIncreaseSpeed.Size = new System.Drawing.Size(168, 40);
            this.buttonIncreaseSpeed.TabIndex = 10;
            this.buttonIncreaseSpeed.Text = "Increase Speed (F9)";
            this.buttonIncreaseSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonIncreaseSpeed.UseVisualStyleBackColor = true;
            this.buttonIncreaseSpeed.Click += new System.EventHandler(this.OnHandlerIncreaseSpeed);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(351, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Play (F7)";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnHandlePlayImage);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(241, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Pause (F7)";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnHandlerPauseImage);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(64, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 39);
            this.button4.TabIndex = 14;
            this.button4.Text = "Decrease Speed (F6)";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnHandlerDecreseadSpeed);
            // 
            // Review
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(993, 737);
            this.Controls.Add(this.tabControl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Review";
            this.RightToLeftLayout = true;
            this.Text = "Challenge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.CheckBox checkBoxDamagesFound;
        private System.Windows.Forms.CheckBox checkBoxHazards;
        private System.Windows.Forms.CheckBox checkBoxSealPresent;
        private System.Windows.Forms.PictureBox slidePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBoxZoom;
        private System.Windows.Forms.ProgressBar progressBarIndicator;
        private System.Windows.Forms.TextBox richTextBoxNotes;
        private System.Windows.Forms.Button buttonIncreaseSpeed;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

