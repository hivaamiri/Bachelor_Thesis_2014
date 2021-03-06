﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog openFrom = new OpenFileDialog();
        SaveFileDialog saveTo = new SaveFileDialog();

        //##########################################################################        
        private void BrowseInputPic_Click(object sender, EventArgs e)
        {
            openFrom.Filter = "Text Files (.png)|*.png|All Files (*.*)|*.*";
            openFrom.FilterIndex = 1;
            if (openFrom.ShowDialog() == DialogResult.OK)
            {

                variables.filePathWrite = openFrom.FileName;
                InputPathLabel.Text = variables.filePathWrite;
                variables.test = true;
                Bitmap temp = new Bitmap(variables.filePathWrite);
                labelPhotoSize.Text = Convert.ToString(temp.Width) + " x " + Convert.ToString(temp.Height);
                labelTotalPixel.Text = Convert.ToString(temp.Height * temp.Width);
                labelMaxCharToSave.Text = Convert.ToString(((temp.Width * temp.Height) / 2) - 3);
                pictureBox3.Visible = true;
            }
            else
                InputPathLabel.Text = "No File Selected";
        }
        //##########################################################################
        private void StartReading_Click(object sender, EventArgs e)
        {
            openFrom.Filter = "Text Files (.png)|*.png|All Files (*.*)|*.*";
            openFrom.FilterIndex = 1;
            if (openFrom.ShowDialog() == DialogResult.OK)
            {
                labelReadDataPhotoPath.Text = openFrom.FileName;
                variables.filePath = openFrom.FileName;
                InputPathLabel.Text = variables.filePath;
                string base3T = null;
                string codeLength = null;
                int codeL = 0;
                int red, green, blue, x, y, z;
                Bitmap myBitmap = new Bitmap(variables.filePath);
                Color pixelcolor;
                int counter = 0;
                for (y = 0; y < 6; y++)
                {
                    pixelcolor = myBitmap.GetPixel(0, y);
                    codeLength += (pixelcolor.R % 3).ToString();
                    codeLength += (pixelcolor.G % 3).ToString();
                    codeLength += (pixelcolor.B % 3).ToString();
                }

                codeL = Functions.ConvertToBase10(codeLength) + 6;
                for (x = 0; x < myBitmap.Width; x++)
                    for (y = 0; y < myBitmap.Height; y++)
                    {
                        pixelcolor = myBitmap.GetPixel(x, y);
                        red = pixelcolor.R;
                        base3T += (red % 3).ToString();
                        green = pixelcolor.G;
                        base3T += (green % 3).ToString();
                        blue = pixelcolor.B;
                        base3T += (blue % 3).ToString();
                        counter++;
                        if (counter == codeL)
                            goto done;
                    }
            done:
                string[] base3t = new string[(base3T.Length) / 6];
                z = 0;
                string key = null;
                for (x = 18; x < base3T.Length; x += 6)
                {
                    base3t[z] = Functions.ConvertToBase10(base3T.Substring(x, 6)).ToString();
                    key += char.ConvertFromUtf32(Functions.ConvertToBase10(base3T.Substring(x, 6))).ToString();
                    z++;
                }
                SecretData.Text = key;
                labelTotalHidden.Text = key.Length.ToString();
            }// end ResultDialog IF
            else
                SecretData.Text = "ERROR, No File Selected";
        }
        //##########################################################################
        private void StartHidding_Click(object sender, EventArgs e)
        {
            if (variables.test == true)
            {
                variables.MyBitmap = new Bitmap(variables.filePathWrite);
                Color pixelcolor;
                string secretKey = SecretData.Text;
                string base3T = null;
                string base3;
                string format;
                int calculateMaxData;
                calculateMaxData = ((variables.MyBitmap.Width * variables.MyBitmap.Height) / 2) - 3;
                if (SecretData.TextLength < calculateMaxData)
                {
                    format = Functions.ConvertToBase3(secretKey.Length * 2, 3).PadLeft(18, '0');
                    base3T += format;

                    for (int t = 0; t < secretKey.Length; t++)
                    {
                        int ascii = int.Parse(new string(Encoding.ASCII.GetBytes(secretKey.Substring(t, 1)).SelectMany(b => b.ToString()).ToArray()));
                        base3 = Functions.ConvertToBase3(ascii, 3);
                        var padding = base3.PadLeft(6, '0');
                        base3T += padding;
                    }

                    int x, y, red, green, blue;
                    int temp = 0;
                    for (x = 0; x < variables.MyBitmap.Width; x++)
                        for (y = 0; y < variables.MyBitmap.Height; y++)
                        {
                            pixelcolor = variables.MyBitmap.GetPixel(x, y);
                            red = Functions.setPixel(int.Parse(base3T.Substring(temp, 1)), pixelcolor.R);
                            temp++;
                            green = Functions.setPixel(int.Parse(base3T.Substring(temp, 1)), pixelcolor.G);
                            temp++;
                            blue = Functions.setPixel(int.Parse(base3T.Substring(temp, 1)), pixelcolor.B);
                            temp++;
                            variables.MyBitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                            if (temp == base3T.Length)
                                goto done;
                        }
                done:
                    saveTo.Filter = "txt files (*.png)|*.png";
                    saveTo.FilterIndex = 2;
                    saveTo.RestoreDirectory = true;
                    if (saveTo.ShowDialog() == DialogResult.OK)
                    {
                        variables.MyBitmap.Save(saveTo.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        labelHidedImagePath.Text = saveTo.FileName;
                        labelStatus.Text = "Succeed !";
                    }
                    else
                        variables.MyBitmap = null;


                }//if (SecretData.TextLength < calculateMaxData)
                else
                    MessageBox.Show("SecretData is to large!\nPlease select a larger photo or reduce SecretData length");
            }//if (variables.test == true)
            else
                MessageBox.Show("ERROR, Choose a Photo");
        }
        //##########################################################################
        private void TextfileBrowse_Click(object sender, EventArgs e)
        {
            openFrom.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFrom.FilterIndex = 1;
            if (openFrom.ShowDialog() == DialogResult.OK)
            {
                labelReadDataFromTXT.Text = openFrom.FileName + " Selected";
                variables.filePath = openFrom.FileName;
                string text = System.IO.File.ReadAllText(variables.filePath);
                SecretData.Text = text;
                pictureBox4.Visible = true;
            }
        }
        //##########################################################################
        private void saveDataBut_Click(object sender, EventArgs e)
        {
            saveTo.Filter = "txt files (*.txt)|*.txt";
            saveTo.FilterIndex = 2;
            saveTo.RestoreDirectory = true;
            if (saveTo.ShowDialog() == DialogResult.OK)
            {
                labelSaveDataTXTafterReadPath.Text = saveTo.FileName;
                System.IO.File.WriteAllText(saveTo.FileName, SecretData.Text);
            }
        }
        //##########################################################################
        private void ClearForm_Click(object sender, EventArgs e)
        {
            SecretData.Text = null;
            variables.filePath = null;
            variables.filePathWrite = null;
            variables.test = false;
            variables.P2PSecret = false;
            variables.P2PMain = false;
            InputPathLabel.Text = null;
            labelStatus.Text = null;
            labelTotalPixel.Text = null;
            labelTotalHidden.Text = null;
            labelSaveDataTXTafterReadPath.Text = null;
            labelReadDataPhotoPath.Text = null;
            labelReadDataFromTXT.Text = null;
            labelPhotoSize.Text = null;
            labelMaxCharToSave.Text = null;
            labelHidedImagePath.Text = null;
            labelCharInTextbox.Text = null;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            checkBox1.Checked = false;
            
        }

        private void SecretData_TextChanged(object sender, EventArgs e)
        {
            labelCharInTextbox.Text = SecretData.TextLength.ToString();
        }

        private void labelHidedImagePath_Click(object sender, EventArgs e)
        {

        }

        private void labelReadDataFromTXT_Click(object sender, EventArgs e)
        {

        }
        //##########################################################################
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (variables.P2PMain && variables.P2PSecret)
            {
                
                Bitmap BitmapOut = new Bitmap(variables.filePathSecretPhoto);
                variables.MyBitmap = new Bitmap(variables.filePath);
                Color ColorPixelIn;
                Color ColorPixelOut;
                string ImageValuesInbase3 = Functions.ConvertToBase3(variables.MyBitmap.Width * variables.MyBitmap.Height * 6, 3).ToString().PadLeft(18, '0');
                ImageValuesInbase3 += Functions.ConvertToBase3(variables.MyBitmap.Width, 3).PadLeft(9, '0');
                ImageValuesInbase3 += Functions.ConvertToBase3(variables.MyBitmap.Height, 3).PadLeft(9, '0');
                for (int i = 0; i < variables.MyBitmap.Width; i++)
                    for (int j = 0; j < variables.MyBitmap.Height; j++)
                    {
                        ColorPixelIn = variables.MyBitmap.GetPixel(i, j);
                        ImageValuesInbase3 += Functions.ConvertToBase3(ColorPixelIn.R, 3).PadLeft(6, '0');
                        ImageValuesInbase3 += Functions.ConvertToBase3(ColorPixelIn.G, 3).PadLeft(6, '0');
                        ImageValuesInbase3 += Functions.ConvertToBase3(ColorPixelIn.B, 3).PadLeft(6, '0');
                    }
                int x, y, red, green, blue, temp = 0;
                for (x = 0; x < BitmapOut.Width; x++)
                    for (y = 0; y < BitmapOut.Height; y++)
                    {
                        ColorPixelOut = BitmapOut.GetPixel(x, y);
                        red = Functions.setPixel(int.Parse(ImageValuesInbase3.Substring(temp, 1)), ColorPixelOut.R);
                        temp++;
                        green = Functions.setPixel(int.Parse(ImageValuesInbase3.Substring(temp, 1)), ColorPixelOut.G);
                        temp++;
                        blue = Functions.setPixel(int.Parse(ImageValuesInbase3.Substring(temp, 1)), ColorPixelOut.B);
                        temp++;
                        BitmapOut.SetPixel(x, y, Color.FromArgb(red, green, blue));
                        if (temp == ImageValuesInbase3.Length)
                            goto done;
                    }
            done:
                saveTo.Filter = "txt files (*.png)|*.png";
                saveTo.FilterIndex = 2;
                saveTo.RestoreDirectory = true;
                if (saveTo.ShowDialog() == DialogResult.OK)
                {
                    BitmapOut.Save(saveTo.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    labelHidedImagePath.Text = saveTo.FileName;
                    labelStatus.Text = "Succeed !";
                }
            }
            else
                MessageBox.Show("Select Photos.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        //##########################################################################
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                buttonBrowseSecretPhoto.Enabled = true;
                buttonHidePhotoInPhoto.Enabled = true;
                buttonBrowseMainPhoto.Enabled = true;
            }
            else
            {
                buttonBrowseSecretPhoto.Enabled = false;
                buttonHidePhotoInPhoto.Enabled = false;
                buttonBrowseMainPhoto.Enabled = false;
            }

        }
        //##########################################################################
        private void button1_Click(object sender, EventArgs e)
        {
            openFrom.Filter = "Text Files (.png)|*.png|All Files (*.*)|*.*";
            openFrom.FilterIndex = 1;
            openFrom.Title = "Select Photo ...";
            if (openFrom.ShowDialog() == DialogResult.OK)
            {
                labelStatus.Text = "Wait...";
                variables.filePath = openFrom.FileName;
                string base3T = null;
                string codeLength = null;
                string PicSizeW = null;
                string PicSizeH = null;
                int codeL = 0;
                int x, y, red, green, blue;
                int[] c = new int[4];
                Bitmap myBitmap = new Bitmap(variables.filePath);
                Color pixelcolor;
                int counter = 0;

                for (x = 0; x < myBitmap.Width; x++)
                    for (y = 0; y < myBitmap.Height; y++)
                    {
                        if (counter < 6)
                        {
                            pixelcolor = myBitmap.GetPixel(x, y);
                            codeLength += (pixelcolor.R % 3).ToString();
                            codeLength += (pixelcolor.G % 3).ToString();
                            codeLength += (pixelcolor.B % 3).ToString();
                        }
                        if ((counter >= 6) && (counter < 9))
                        {
                            pixelcolor = myBitmap.GetPixel(x, y);
                            PicSizeW += (pixelcolor.R % 3).ToString();
                            PicSizeW += (pixelcolor.G % 3).ToString();
                            PicSizeW += (pixelcolor.B % 3).ToString();
                        }
                        if ((counter >= 9) && (counter < 12))
                        {
                            pixelcolor = myBitmap.GetPixel(x, y);
                            PicSizeH += (pixelcolor.R % 3).ToString();
                            PicSizeH += (pixelcolor.G % 3).ToString();
                            PicSizeH += (pixelcolor.B % 3).ToString();
                        }
                        if (counter == 12)
                            goto endFor;
                        counter++;
                    }

            endFor: ;
                x = Functions.ConvertToBase10(PicSizeW);
                y = Functions.ConvertToBase10(PicSizeH);
                Bitmap BitmapOut = new Bitmap(x, y);
                int check = 0;
                codeL = Functions.ConvertToBase10(codeLength) + 12;
                for (x = 0; x < myBitmap.Width; x++)
                    for (y = 0; y < myBitmap.Height; y++)
                    {
                        if (check >= 12)
                        {
                            pixelcolor = myBitmap.GetPixel(x, y);
                            base3T += (pixelcolor.R % 3).ToString();
                            base3T += (pixelcolor.G % 3).ToString();
                            base3T += (pixelcolor.B % 3).ToString();
                            if (check + 1 == codeL)
                                goto done;
                        }
                        check++;
                    }
            done:
                counter = 0;
                check = 0;
                for (x = 0; x < BitmapOut.Width; x++)
                    for (y = 0; y < BitmapOut.Height; y++)
                    {
                        red = Functions.ConvertToBase10(base3T.Substring(counter, 6));
                        counter += 6;
                        green = Functions.ConvertToBase10(base3T.Substring(counter, 6));
                        counter += 6;
                        blue = Functions.ConvertToBase10(base3T.Substring(counter, 6));
                        counter += 6;
                        BitmapOut.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                saveTo.Filter = "PNG files (*.png)|*.png";
                saveTo.FilterIndex = 2;
                saveTo.RestoreDirectory = true;
                if (saveTo.ShowDialog() == DialogResult.OK)
                {
                    BitmapOut.Save(saveTo.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    labelHidedImagePath.Text = saveTo.FileName;
                    labelStatus.Text = "Succeed !";
                }
                else
                    
                    MessageBox.Show("Hidden Photo is not Saved","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Photo Not Selected", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        private void buttonBrowseSecretPhoto_Click(object sender, EventArgs e)
        {
            openFrom.Filter = "Text Files (.png)|*.png|All Files (*.*)|*.*";
            openFrom.FilterIndex = 1;
            openFrom.Title = "Select Secret Photo ...";
            if (openFrom.ShowDialog() == DialogResult.OK)
            {
                variables.filePath = openFrom.FileName;
                pictureBox1.Visible = true;
                variables.P2PSecret = true;
            }
        }

        private void buttonBrowseMainPhoto_Click(object sender, EventArgs e)
        {
            openFrom.Filter = "Text Files (.png)|*.png|All Files (*.*)|*.*";
            openFrom.FilterIndex = 1;
            openFrom.Title = "Select Main Photo ...";
            if (openFrom.ShowDialog() == DialogResult.OK)
            {
                variables.filePathSecretPhoto = openFrom.FileName;
                pictureBox2.Visible = true;
                variables.P2PMain = true;
            }
        }
    }
}    
