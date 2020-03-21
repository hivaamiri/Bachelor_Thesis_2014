namespace Steganography
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonHidePhotoInPhoto = new System.Windows.Forms.Button();
            this.buttonBrowseSecretPhoto = new System.Windows.Forms.Button();
            this.labelHidedImagePath = new System.Windows.Forms.Label();
            this.TextfileBrowse = new System.Windows.Forms.Button();
            this.labelReadDataFromTXT = new System.Windows.Forms.Label();
            this.StartHidding = new System.Windows.Forms.Button();
            this.InputPathLabel = new System.Windows.Forms.Label();
            this.BrowseInputPic = new System.Windows.Forms.Button();
            this.ClearForm = new System.Windows.Forms.Button();
            this.saveDataBut = new System.Windows.Forms.Button();
            this.StartReading = new System.Windows.Forms.Button();
            this.SecretData = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSaveDataTXTafterReadPath = new System.Windows.Forms.Label();
            this.labelReadDataPhotoPath = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Summary = new System.Windows.Forms.GroupBox();
            this.labelCharInTextbox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotalHidden = new System.Windows.Forms.Label();
            this.labelMaxCharToSave = new System.Windows.Forms.Label();
            this.labelTotalPixel = new System.Windows.Forms.Label();
            this.labelPhotoSize = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBrowseMainPhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.buttonBrowseMainPhoto);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.buttonHidePhotoInPhoto);
            this.groupBox1.Controls.Add(this.buttonBrowseSecretPhoto);
            this.groupBox1.Controls.Add(this.labelHidedImagePath);
            this.groupBox1.Controls.Add(this.TextfileBrowse);
            this.groupBox1.Controls.Add(this.labelReadDataFromTXT);
            this.groupBox1.Controls.Add(this.StartHidding);
            this.groupBox1.Controls.Add(this.InputPathLabel);
            this.groupBox1.Controls.Add(this.BrowseInputPic);
            this.groupBox1.Location = new System.Drawing.Point(165, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hide SecretData";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(203, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Hide Stegano Photo in Another photo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonHidePhotoInPhoto
            // 
            this.buttonHidePhotoInPhoto.Enabled = false;
            this.buttonHidePhotoInPhoto.Location = new System.Drawing.Point(6, 163);
            this.buttonHidePhotoInPhoto.Name = "buttonHidePhotoInPhoto";
            this.buttonHidePhotoInPhoto.Size = new System.Drawing.Size(125, 23);
            this.buttonHidePhotoInPhoto.TabIndex = 9;
            this.buttonHidePhotoInPhoto.Text = "Hide Stegano Photo";
            this.buttonHidePhotoInPhoto.UseVisualStyleBackColor = true;
            this.buttonHidePhotoInPhoto.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBrowseSecretPhoto
            // 
            this.buttonBrowseSecretPhoto.Enabled = false;
            this.buttonBrowseSecretPhoto.Location = new System.Drawing.Point(6, 134);
            this.buttonBrowseSecretPhoto.Name = "buttonBrowseSecretPhoto";
            this.buttonBrowseSecretPhoto.Size = new System.Drawing.Size(125, 23);
            this.buttonBrowseSecretPhoto.TabIndex = 8;
            this.buttonBrowseSecretPhoto.Text = "Browse Secret Photo";
            this.buttonBrowseSecretPhoto.UseVisualStyleBackColor = true;
            this.buttonBrowseSecretPhoto.Click += new System.EventHandler(this.buttonBrowseSecretPhoto_Click);
            // 
            // labelHidedImagePath
            // 
            this.labelHidedImagePath.AllowDrop = true;
            this.labelHidedImagePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHidedImagePath.AutoSize = true;
            this.labelHidedImagePath.Location = new System.Drawing.Point(102, 83);
            this.labelHidedImagePath.Name = "labelHidedImagePath";
            this.labelHidedImagePath.Size = new System.Drawing.Size(0, 13);
            this.labelHidedImagePath.TabIndex = 7;
            this.labelHidedImagePath.Click += new System.EventHandler(this.labelHidedImagePath_Click);
            // 
            // TextfileBrowse
            // 
            this.TextfileBrowse.Location = new System.Drawing.Point(6, 48);
            this.TextfileBrowse.Name = "TextfileBrowse";
            this.TextfileBrowse.Size = new System.Drawing.Size(90, 23);
            this.TextfileBrowse.TabIndex = 6;
            this.TextfileBrowse.Text = "Browse Text file";
            this.TextfileBrowse.UseVisualStyleBackColor = true;
            this.TextfileBrowse.Click += new System.EventHandler(this.TextfileBrowse_Click);
            // 
            // labelReadDataFromTXT
            // 
            this.labelReadDataFromTXT.AllowDrop = true;
            this.labelReadDataFromTXT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelReadDataFromTXT.AutoSize = true;
            this.labelReadDataFromTXT.Location = new System.Drawing.Point(131, 53);
            this.labelReadDataFromTXT.Name = "labelReadDataFromTXT";
            this.labelReadDataFromTXT.Size = new System.Drawing.Size(229, 13);
            this.labelReadDataFromTXT.TabIndex = 5;
            this.labelReadDataFromTXT.Text = "Write SecretData in Textbox or select a text file";
            this.labelReadDataFromTXT.Click += new System.EventHandler(this.labelReadDataFromTXT_Click);
            // 
            // StartHidding
            // 
            this.StartHidding.Location = new System.Drawing.Point(6, 77);
            this.StartHidding.Name = "StartHidding";
            this.StartHidding.Size = new System.Drawing.Size(90, 23);
            this.StartHidding.TabIndex = 3;
            this.StartHidding.Text = "Hide data";
            this.StartHidding.UseVisualStyleBackColor = true;
            this.StartHidding.Click += new System.EventHandler(this.StartHidding_Click);
            // 
            // InputPathLabel
            // 
            this.InputPathLabel.AutoSize = true;
            this.InputPathLabel.Location = new System.Drawing.Point(131, 24);
            this.InputPathLabel.Name = "InputPathLabel";
            this.InputPathLabel.Size = new System.Drawing.Size(0, 13);
            this.InputPathLabel.TabIndex = 1;
            // 
            // BrowseInputPic
            // 
            this.BrowseInputPic.Location = new System.Drawing.Point(6, 19);
            this.BrowseInputPic.Name = "BrowseInputPic";
            this.BrowseInputPic.Size = new System.Drawing.Size(90, 23);
            this.BrowseInputPic.TabIndex = 0;
            this.BrowseInputPic.Text = "Browse photo";
            this.BrowseInputPic.UseVisualStyleBackColor = true;
            this.BrowseInputPic.Click += new System.EventHandler(this.BrowseInputPic_Click);
            // 
            // ClearForm
            // 
            this.ClearForm.Location = new System.Drawing.Point(6, 426);
            this.ClearForm.Name = "ClearForm";
            this.ClearForm.Size = new System.Drawing.Size(85, 23);
            this.ClearForm.TabIndex = 8;
            this.ClearForm.Text = "Clear Form";
            this.ClearForm.UseVisualStyleBackColor = true;
            this.ClearForm.Click += new System.EventHandler(this.ClearForm_Click);
            // 
            // saveDataBut
            // 
            this.saveDataBut.Location = new System.Drawing.Point(6, 48);
            this.saveDataBut.Name = "saveDataBut";
            this.saveDataBut.Size = new System.Drawing.Size(125, 23);
            this.saveDataBut.TabIndex = 7;
            this.saveDataBut.Text = "Save Data as .txt File";
            this.saveDataBut.UseVisualStyleBackColor = true;
            this.saveDataBut.Click += new System.EventHandler(this.saveDataBut_Click);
            // 
            // StartReading
            // 
            this.StartReading.Location = new System.Drawing.Point(6, 19);
            this.StartReading.Name = "StartReading";
            this.StartReading.Size = new System.Drawing.Size(125, 23);
            this.StartReading.TabIndex = 4;
            this.StartReading.Text = "Read data";
            this.StartReading.UseVisualStyleBackColor = true;
            this.StartReading.Click += new System.EventHandler(this.StartReading_Click);
            // 
            // SecretData
            // 
            this.SecretData.Location = new System.Drawing.Point(6, 19);
            this.SecretData.Multiline = true;
            this.SecretData.Name = "SecretData";
            this.SecretData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SecretData.Size = new System.Drawing.Size(153, 401);
            this.SecretData.TabIndex = 2;
            this.SecretData.TextChanged += new System.EventHandler(this.SecretData_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.labelSaveDataTXTafterReadPath);
            this.groupBox2.Controls.Add(this.labelReadDataPhotoPath);
            this.groupBox2.Controls.Add(this.StartReading);
            this.groupBox2.Controls.Add(this.saveDataBut);
            this.groupBox2.Location = new System.Drawing.Point(165, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 107);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read SecretData";
            // 
            // labelSaveDataTXTafterReadPath
            // 
            this.labelSaveDataTXTafterReadPath.AllowDrop = true;
            this.labelSaveDataTXTafterReadPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSaveDataTXTafterReadPath.AutoSize = true;
            this.labelSaveDataTXTafterReadPath.Location = new System.Drawing.Point(137, 52);
            this.labelSaveDataTXTafterReadPath.Name = "labelSaveDataTXTafterReadPath";
            this.labelSaveDataTXTafterReadPath.Size = new System.Drawing.Size(0, 13);
            this.labelSaveDataTXTafterReadPath.TabIndex = 8;
            // 
            // labelReadDataPhotoPath
            // 
            this.labelReadDataPhotoPath.AllowDrop = true;
            this.labelReadDataPhotoPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelReadDataPhotoPath.AutoSize = true;
            this.labelReadDataPhotoPath.Location = new System.Drawing.Point(137, 23);
            this.labelReadDataPhotoPath.Name = "labelReadDataPhotoPath";
            this.labelReadDataPhotoPath.Size = new System.Drawing.Size(0, 13);
            this.labelReadDataPhotoPath.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Summary);
            this.groupBox3.Controls.Add(this.SecretData);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.ClearForm);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 456);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // Summary
            // 
            this.Summary.Controls.Add(this.labelCharInTextbox);
            this.Summary.Controls.Add(this.label6);
            this.Summary.Controls.Add(this.labelTotalHidden);
            this.Summary.Controls.Add(this.labelMaxCharToSave);
            this.Summary.Controls.Add(this.labelTotalPixel);
            this.Summary.Controls.Add(this.labelPhotoSize);
            this.Summary.Controls.Add(this.labelStatus);
            this.Summary.Controls.Add(this.label4);
            this.Summary.Controls.Add(this.label3);
            this.Summary.Controls.Add(this.label2);
            this.Summary.Controls.Add(this.label1);
            this.Summary.Location = new System.Drawing.Point(165, 324);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(467, 121);
            this.Summary.TabIndex = 10;
            this.Summary.TabStop = false;
            this.Summary.Text = "Summary";
            // 
            // labelCharInTextbox
            // 
            this.labelCharInTextbox.AllowDrop = true;
            this.labelCharInTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCharInTextbox.AutoSize = true;
            this.labelCharInTextbox.Location = new System.Drawing.Point(161, 68);
            this.labelCharInTextbox.Name = "labelCharInTextbox";
            this.labelCharInTextbox.Size = new System.Drawing.Size(0, 13);
            this.labelCharInTextbox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.Location = new System.Drawing.Point(3, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total Characters in Textbox";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalHidden
            // 
            this.labelTotalHidden.AllowDrop = true;
            this.labelTotalHidden.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTotalHidden.AutoSize = true;
            this.labelTotalHidden.Location = new System.Drawing.Point(161, 102);
            this.labelTotalHidden.Name = "labelTotalHidden";
            this.labelTotalHidden.Size = new System.Drawing.Size(0, 13);
            this.labelTotalHidden.TabIndex = 16;
            // 
            // labelMaxCharToSave
            // 
            this.labelMaxCharToSave.AllowDrop = true;
            this.labelMaxCharToSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMaxCharToSave.AutoSize = true;
            this.labelMaxCharToSave.Location = new System.Drawing.Point(161, 49);
            this.labelMaxCharToSave.Name = "labelMaxCharToSave";
            this.labelMaxCharToSave.Size = new System.Drawing.Size(0, 13);
            this.labelMaxCharToSave.TabIndex = 15;
            // 
            // labelTotalPixel
            // 
            this.labelTotalPixel.AllowDrop = true;
            this.labelTotalPixel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTotalPixel.AutoSize = true;
            this.labelTotalPixel.Location = new System.Drawing.Point(161, 32);
            this.labelTotalPixel.Name = "labelTotalPixel";
            this.labelTotalPixel.Size = new System.Drawing.Size(0, 13);
            this.labelTotalPixel.TabIndex = 14;
            // 
            // labelPhotoSize
            // 
            this.labelPhotoSize.AllowDrop = true;
            this.labelPhotoSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPhotoSize.AutoSize = true;
            this.labelPhotoSize.Location = new System.Drawing.Point(161, 16);
            this.labelPhotoSize.Name = "labelPhotoSize";
            this.labelPhotoSize.Size = new System.Drawing.Size(0, 13);
            this.labelPhotoSize.TabIndex = 13;
            // 
            // labelStatus
            // 
            this.labelStatus.AllowDrop = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelStatus.Location = new System.Drawing.Point(315, 49);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(101, 19);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Hidden ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Max Characters Can Hide";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Pixels";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Photo Size";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Execute Stegano Photo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBrowseMainPhoto
            // 
            this.buttonBrowseMainPhoto.Enabled = false;
            this.buttonBrowseMainPhoto.Location = new System.Drawing.Point(164, 134);
            this.buttonBrowseMainPhoto.Name = "buttonBrowseMainPhoto";
            this.buttonBrowseMainPhoto.Size = new System.Drawing.Size(117, 23);
            this.buttonBrowseMainPhoto.TabIndex = 11;
            this.buttonBrowseMainPhoto.Text = "Browse Main Photo";
            this.buttonBrowseMainPhoto.UseVisualStyleBackColor = true;
            this.buttonBrowseMainPhoto.Click += new System.EventHandler(this.buttonBrowseMainPhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(287, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(102, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(102, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 476);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Steganography";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Summary.ResumeLayout(false);
            this.Summary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StartReading;
        private System.Windows.Forms.Button StartHidding;
        private System.Windows.Forms.TextBox SecretData;
        private System.Windows.Forms.Label InputPathLabel;
        private System.Windows.Forms.Button BrowseInputPic;
        private System.Windows.Forms.Button saveDataBut;
        private System.Windows.Forms.Button TextfileBrowse;
        private System.Windows.Forms.Label labelReadDataFromTXT;
        private System.Windows.Forms.Button ClearForm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelSaveDataTXTafterReadPath;
        private System.Windows.Forms.Label labelReadDataPhotoPath;
        private System.Windows.Forms.Label labelHidedImagePath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox Summary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalHidden;
        private System.Windows.Forms.Label labelMaxCharToSave;
        private System.Windows.Forms.Label labelTotalPixel;
        private System.Windows.Forms.Label labelPhotoSize;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCharInTextbox;
        private System.Windows.Forms.Button buttonHidePhotoInPhoto;
        private System.Windows.Forms.Button buttonBrowseSecretPhoto;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBrowseMainPhoto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

