using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ConvertImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Bitmap Base64ToImage()
        {
            // Convert Base64 String to byte[]
            if(openXmlDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openXmlDialog.FileName))
                {
                    StreamReader sr = new StreamReader(openXmlDialog.FileName);
                    string text = sr.ReadToEnd();
                    sr.Close();
                    //FileStream fs = File.Open(openFileDialog1.FileName, FileMode.Open);
                    byte[] imageBytes = Convert.FromBase64String(text);
                    //fs.Read(imageBytes, 0, (int)imageBytes.Length-1);
                    MemoryStream ms = new MemoryStream(imageBytes);

                    // Convert byte[] to Image
                    //ms.Write(imageBytes, 0, imageBytes.Length);
                    Bitmap bmp = new Bitmap(ms);
                    return bmp;
                }
            }
            return null;
        }
        public string ImageToBase64()
        {
            byte[] base64CharArray;
            if(openImageDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openImageDialog.FileName))
                {
                    FileStream inFile;
                    string base64String;
                    StringBuilder SB = new StringBuilder();
                    inFile = new System.IO.FileStream(openImageDialog.FileName,
                                       System.IO.FileMode.Open,
                                       System.IO.FileAccess.Read);

                    base64CharArray = new byte[inFile.Length];
                    inFile.Read(base64CharArray, 0, (int)inFile.Length);
                    inFile.Close();

                    // convert from binary data to BASE64 decoding

                    base64String = System.Convert.ToBase64String(base64CharArray, 0, base64CharArray.Length);

                    // convert from BASE64 decoding to binary data

                    byte[] binaryData;

                    binaryData = System.Convert.FromBase64String(base64String);

                    return base64String;
                }
            }
            return "";
        }

        private void btnFromXml_Click(object sender, EventArgs e)
        {
            Bitmap img = Base64ToImage();
            if (null != img)
            {
                if(saveImageDialog.ShowDialog() == DialogResult.OK)
                {
                    img.Save(saveImageDialog.FileName);
                }
                else
                {
                    MessageBox.Show("Can you pick a right position?");
                }
            }
        }

        private void btnFromImage_Click(object sender, EventArgs e)
        {
            string base64Bytes = ImageToBase64();
            if("" != base64Bytes)
            {
                if(saveXmlDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveXmlDialog.FileName))
                    {
                        sw.Write(base64Bytes);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
        }
    }
}
