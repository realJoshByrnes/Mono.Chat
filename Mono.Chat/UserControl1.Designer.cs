namespace Mono.Chat
{
    partial class ChatHeader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatHeader));
            leftImage = new PictureBox();
            rightImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)leftImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightImage).BeginInit();
            SuspendLayout();
            // 
            // leftImage
            // 
            leftImage.BackgroundImage = (Image)resources.GetObject("leftImage.BackgroundImage");
            leftImage.Location = new Point(0, 0);
            leftImage.Name = "leftImage";
            leftImage.Size = new Size(492, 106);
            leftImage.TabIndex = 0;
            leftImage.TabStop = false;
            // 
            // rightImage
            // 
            rightImage.BackgroundImage = (Image)resources.GetObject("rightImage.BackgroundImage");
            rightImage.Location = new Point(0, 0);
            rightImage.Name = "rightImage";
            rightImage.Size = new Size(500, 106);
            rightImage.TabIndex = 1;
            rightImage.TabStop = false;
            // 
            // ChatHeader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(leftImage);
            Controls.Add(rightImage);
            Name = "ChatHeader";
            Size = new Size(500, 106);
            ((System.ComponentModel.ISupportInitialize)leftImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox leftImage;
        private PictureBox rightImage;
    }
}
