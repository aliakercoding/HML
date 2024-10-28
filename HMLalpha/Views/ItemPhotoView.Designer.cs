namespace HMLalpha.Views
{
    partial class ItemPhotoView
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
            ItemPhoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ItemPhoto).BeginInit();
            SuspendLayout();
            // 
            // ItemPhoto
            // 
            ItemPhoto.Dock = DockStyle.Fill;
            ItemPhoto.Location = new Point(0, 0);
            ItemPhoto.Name = "ItemPhoto";
            ItemPhoto.Size = new Size(291, 236);
            ItemPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            ItemPhoto.TabIndex = 0;
            ItemPhoto.TabStop = false;
            // 
            // ItemPhotoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 236);
            Controls.Add(ItemPhoto);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemPhotoView";
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "صورة الصنف الحالي";
            ((System.ComponentModel.ISupportInitialize)ItemPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox ItemPhoto;
    }
}