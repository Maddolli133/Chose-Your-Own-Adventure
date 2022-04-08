namespace Chose_Your_Own_Adventure
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
            this.blackBox = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.optionOneLabel = new System.Windows.Forms.Label();
            this.optionTwoLabel = new System.Windows.Forms.Label();
            this.optionOneButton = new System.Windows.Forms.Button();
            this.optionTwoButton = new System.Windows.Forms.Button();
            this.storyImages = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.storyImages)).BeginInit();
            this.SuspendLayout();
            // 
            // blackBox
            // 
            this.blackBox.BackColor = System.Drawing.Color.Black;
            this.blackBox.Enabled = false;
            this.blackBox.ForeColor = System.Drawing.Color.Transparent;
            this.blackBox.Location = new System.Drawing.Point(0, 327);
            this.blackBox.Name = "blackBox";
            this.blackBox.Size = new System.Drawing.Size(984, 224);
            this.blackBox.TabIndex = 0;
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.Color.Black;
            this.textLabel.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.ForeColor = System.Drawing.Color.White;
            this.textLabel.Location = new System.Drawing.Point(22, 432);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(940, 109);
            this.textLabel.TabIndex = 1;
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // optionOneLabel
            // 
            this.optionOneLabel.AutoSize = true;
            this.optionOneLabel.BackColor = System.Drawing.Color.Black;
            this.optionOneLabel.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionOneLabel.ForeColor = System.Drawing.Color.Red;
            this.optionOneLabel.Location = new System.Drawing.Point(96, 361);
            this.optionOneLabel.Name = "optionOneLabel";
            this.optionOneLabel.Size = new System.Drawing.Size(0, 24);
            this.optionOneLabel.TabIndex = 2;
            // 
            // optionTwoLabel
            // 
            this.optionTwoLabel.AutoSize = true;
            this.optionTwoLabel.BackColor = System.Drawing.Color.Black;
            this.optionTwoLabel.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTwoLabel.ForeColor = System.Drawing.Color.Red;
            this.optionTwoLabel.Location = new System.Drawing.Point(691, 361);
            this.optionTwoLabel.Name = "optionTwoLabel";
            this.optionTwoLabel.Size = new System.Drawing.Size(0, 24);
            this.optionTwoLabel.TabIndex = 2;
            // 
            // optionOneButton
            // 
            this.optionOneButton.BackColor = System.Drawing.Color.Black;
            this.optionOneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionOneButton.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionOneButton.ForeColor = System.Drawing.Color.Red;
            this.optionOneButton.Location = new System.Drawing.Point(65, 340);
            this.optionOneButton.Name = "optionOneButton";
            this.optionOneButton.Size = new System.Drawing.Size(284, 75);
            this.optionOneButton.TabIndex = 3;
            this.optionOneButton.Text = "Go Left";
            this.optionOneButton.UseVisualStyleBackColor = false;
            this.optionOneButton.Click += new System.EventHandler(this.optionOneButton_Click);
            // 
            // optionTwoButton
            // 
            this.optionTwoButton.BackColor = System.Drawing.Color.Black;
            this.optionTwoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionTwoButton.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTwoButton.ForeColor = System.Drawing.Color.Red;
            this.optionTwoButton.Location = new System.Drawing.Point(660, 340);
            this.optionTwoButton.Name = "optionTwoButton";
            this.optionTwoButton.Size = new System.Drawing.Size(268, 75);
            this.optionTwoButton.TabIndex = 3;
            this.optionTwoButton.Text = "Go Right";
            this.optionTwoButton.UseVisualStyleBackColor = false;
            this.optionTwoButton.Click += new System.EventHandler(this.optionTwoButton_Click);
            // 
            // storyImages
            // 
            this.storyImages.BackColor = System.Drawing.Color.Black;
            this.storyImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storyImages.Dock = System.Windows.Forms.DockStyle.Top;
            this.storyImages.Location = new System.Drawing.Point(0, 0);
            this.storyImages.Name = "storyImages";
            this.storyImages.Size = new System.Drawing.Size(984, 334);
            this.storyImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.storyImages.TabIndex = 4;
            this.storyImages.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 550);
            this.Controls.Add(this.storyImages);
            this.Controls.Add(this.optionTwoButton);
            this.Controls.Add(this.optionOneButton);
            this.Controls.Add(this.optionTwoLabel);
            this.Controls.Add(this.optionOneLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.blackBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adventure Awaits";
            ((System.ComponentModel.ISupportInitialize)(this.storyImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blackBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label optionOneLabel;
        private System.Windows.Forms.Label optionTwoLabel;
        private System.Windows.Forms.Button optionOneButton;
        private System.Windows.Forms.Button optionTwoButton;
        private System.Windows.Forms.PictureBox storyImages;
    }
}

