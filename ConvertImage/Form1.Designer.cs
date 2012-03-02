namespace ConvertImage
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
            this.btnFromImage = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.openXmlDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnFromXml = new System.Windows.Forms.Button();
            this.saveXmlDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnFromImage
            // 
            this.btnFromImage.Location = new System.Drawing.Point(182, 34);
            this.btnFromImage.Name = "btnFromImage";
            this.btnFromImage.Size = new System.Drawing.Size(75, 23);
            this.btnFromImage.TabIndex = 0;
            this.btnFromImage.Text = "FromImage";
            this.btnFromImage.UseVisualStyleBackColor = true;
            this.btnFromImage.Click += new System.EventHandler(this.btnFromImage_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openImageDialog";
            this.openImageDialog.Filter = "Image files (*.png) | *.png";
            // 
            // openXmlDialog
            // 
            this.openXmlDialog.FileName = "openXmlDialog";
            this.openXmlDialog.Filter = "Xml files (*.xml) | *.xml";
            // 
            // btnFromXml
            // 
            this.btnFromXml.Location = new System.Drawing.Point(182, 82);
            this.btnFromXml.Name = "btnFromXml";
            this.btnFromXml.Size = new System.Drawing.Size(75, 23);
            this.btnFromXml.TabIndex = 1;
            this.btnFromXml.Text = "FromXml";
            this.btnFromXml.UseVisualStyleBackColor = true;
            this.btnFromXml.Click += new System.EventHandler(this.btnFromXml_Click);
            // 
            // saveXmlDialog
            // 
            this.saveXmlDialog.Filter = "Xml files (*.xml) | *.xml";
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.Filter = "Image files (*.png) | *.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnFromXml);
            this.Controls.Add(this.btnFromImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFromImage;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.OpenFileDialog openXmlDialog;
        private System.Windows.Forms.Button btnFromXml;
        private System.Windows.Forms.SaveFileDialog saveXmlDialog;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
    }
}

