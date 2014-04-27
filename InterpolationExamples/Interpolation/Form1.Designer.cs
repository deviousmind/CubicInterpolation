namespace Interpolation
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
            this.DrawImageButton = new System.Windows.Forms.Button();
            this.BicubicButton = new System.Windows.Forms.Button();
            this.Images = new System.Windows.Forms.PictureBox();
            this.UpscaleButton = new System.Windows.Forms.Button();
            this.SwitchExample = new System.Windows.Forms.Button();
            this.RotateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawImageButton
            // 
            this.DrawImageButton.Location = new System.Drawing.Point(104, 374);
            this.DrawImageButton.Name = "DrawImageButton";
            this.DrawImageButton.Size = new System.Drawing.Size(75, 23);
            this.DrawImageButton.TabIndex = 0;
            this.DrawImageButton.Text = "Draw Image";
            this.DrawImageButton.UseVisualStyleBackColor = true;
            this.DrawImageButton.Click += new System.EventHandler(this.DrawImageButton_Click);
            // 
            // BicubicButton
            // 
            this.BicubicButton.Location = new System.Drawing.Point(361, 374);
            this.BicubicButton.Name = "BicubicButton";
            this.BicubicButton.Size = new System.Drawing.Size(75, 23);
            this.BicubicButton.TabIndex = 1;
            this.BicubicButton.Text = "Bi-cubic";
            this.BicubicButton.UseVisualStyleBackColor = true;
            this.BicubicButton.Click += new System.EventHandler(this.BicubicButton_Click);
            // 
            // Images
            // 
            this.Images.Location = new System.Drawing.Point(104, 35);
            this.Images.Name = "Images";
            this.Images.Size = new System.Drawing.Size(332, 312);
            this.Images.TabIndex = 3;
            this.Images.TabStop = false;
            // 
            // UpscaleButton
            // 
            this.UpscaleButton.Location = new System.Drawing.Point(233, 374);
            this.UpscaleButton.Name = "UpscaleButton";
            this.UpscaleButton.Size = new System.Drawing.Size(75, 23);
            this.UpscaleButton.TabIndex = 4;
            this.UpscaleButton.Text = "Upscale";
            this.UpscaleButton.UseVisualStyleBackColor = true;
            this.UpscaleButton.Click += new System.EventHandler(this.UpscaleButton_Click);
            // 
            // SwitchExample
            // 
            this.SwitchExample.Location = new System.Drawing.Point(233, 418);
            this.SwitchExample.Name = "SwitchExample";
            this.SwitchExample.Size = new System.Drawing.Size(75, 23);
            this.SwitchExample.TabIndex = 5;
            this.SwitchExample.Text = "Example 2";
            this.SwitchExample.UseVisualStyleBackColor = true;
            this.SwitchExample.Click += new System.EventHandler(this.SwitchExample_Click);
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(233, 374);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(75, 23);
            this.RotateButton.TabIndex = 6;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Visible = false;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 453);
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.SwitchExample);
            this.Controls.Add(this.UpscaleButton);
            this.Controls.Add(this.Images);
            this.Controls.Add(this.BicubicButton);
            this.Controls.Add(this.DrawImageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Images)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DrawImageButton;
        private System.Windows.Forms.Button BicubicButton;
        private System.Windows.Forms.PictureBox Images;
        private System.Windows.Forms.Button UpscaleButton;
        private System.Windows.Forms.Button SwitchExample;
        private System.Windows.Forms.Button RotateButton;
    }
}

