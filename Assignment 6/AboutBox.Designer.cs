namespace Assignment_6
{
    partial class AboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            lblDescription = new Label();
            lblVersion = new Label();
            pctImage = new PictureBox();
            btnOK = new Button();
            lblProductName = new Label();
            ((System.ComponentModel.ISupportInitialize)pctImage).BeginInit();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(13, 129);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(192, 255);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "label1";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(13, 85);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(59, 25);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "label3";
            // 
            // pctImage
            // 
            pctImage.Image = (Image)resources.GetObject("pctImage.Image");
            pctImage.Location = new Point(211, -44);
            pctImage.Name = "pctImage";
            pctImage.Size = new Size(596, 497);
            pctImage.TabIndex = 3;
            pctImage.TabStop = false;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(43, 387);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 34);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(13, 44);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(59, 25);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "label2";
            // 
            // AboutBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOK);
            Controls.Add(pctImage);
            Controls.Add(lblVersion);
            Controls.Add(lblProductName);
            Controls.Add(lblDescription);
            Name = "AboutBox";
            Text = "About the program";
            ((System.ComponentModel.ISupportInitialize)pctImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescription;
        private Label lblVersion;
        private PictureBox pctImage;
        private Button btnOK;
        private Label lblProductName;
    }
}