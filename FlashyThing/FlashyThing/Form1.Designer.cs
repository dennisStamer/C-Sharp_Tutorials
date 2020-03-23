namespace FlashyThing
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
            this.startFlashButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startFlashButton
            // 
            this.startFlashButton.Location = new System.Drawing.Point(100, 59);
            this.startFlashButton.Name = "startFlashButton";
            this.startFlashButton.Size = new System.Drawing.Size(116, 117);
            this.startFlashButton.TabIndex = 0;
            this.startFlashButton.Text = "Go!";
            this.startFlashButton.UseVisualStyleBackColor = true;
            this.startFlashButton.Click += new System.EventHandler(this.startFlashButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 276);
            this.Controls.Add(this.startFlashButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startFlashButton;
    }
}

