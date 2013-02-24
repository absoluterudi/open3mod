﻿namespace open3mod
{
    partial class TextureThumbnailControl
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.texCaptionLabel = new System.Windows.Forms.Label();
            this.labelOldTexture = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(9, 8);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(210, 210);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // texCaptionLabel
            // 
            this.texCaptionLabel.AutoSize = true;
            this.texCaptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.texCaptionLabel.Location = new System.Drawing.Point(7, 223);
            this.texCaptionLabel.Name = "texCaptionLabel";
            this.texCaptionLabel.Size = new System.Drawing.Size(99, 13);
            this.texCaptionLabel.TabIndex = 1;
            this.texCaptionLabel.Text = "ATextureName.png";
            // 
            // labelOldTexture
            // 
            this.labelOldTexture.AutoSize = true;
            this.labelOldTexture.BackColor = System.Drawing.Color.Transparent;
            this.labelOldTexture.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldTexture.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelOldTexture.Location = new System.Drawing.Point(9, 230);
            this.labelOldTexture.Name = "labelOldTexture";
            this.labelOldTexture.Size = new System.Drawing.Size(29, 12);
            this.labelOldTexture.TabIndex = 2;
            this.labelOldTexture.Text = "label1";
            // 
            // TextureThumbnailControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelOldTexture);
            this.Controls.Add(this.texCaptionLabel);
            this.Controls.Add(this.pictureBox);
            this.DoubleBuffered = true;
            this.Name = "TextureThumbnailControl";
            this.Size = new System.Drawing.Size(228, 245);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label texCaptionLabel;
        private System.Windows.Forms.Label labelOldTexture;
    }
}
