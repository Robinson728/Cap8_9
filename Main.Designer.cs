
namespace Cap8_9
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cap8Button = new System.Windows.Forms.Button();
            this.Cap9Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cap8Button
            // 
            this.Cap8Button.Location = new System.Drawing.Point(12, 12);
            this.Cap8Button.Name = "Cap8Button";
            this.Cap8Button.Size = new System.Drawing.Size(135, 40);
            this.Cap8Button.TabIndex = 0;
            this.Cap8Button.Text = "Capitulo #8";
            this.Cap8Button.UseVisualStyleBackColor = true;
            this.Cap8Button.Click += new System.EventHandler(this.Cap8Button_Click);
            // 
            // Cap9Button
            // 
            this.Cap9Button.Location = new System.Drawing.Point(166, 12);
            this.Cap9Button.Name = "Cap9Button";
            this.Cap9Button.Size = new System.Drawing.Size(135, 40);
            this.Cap9Button.TabIndex = 1;
            this.Cap9Button.Text = "Capitulo #9";
            this.Cap9Button.UseVisualStyleBackColor = true;
            this.Cap9Button.Click += new System.EventHandler(this.Cap9Button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 59);
            this.Controls.Add(this.Cap9Button);
            this.Controls.Add(this.Cap8Button);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cap8Button;
        private System.Windows.Forms.Button Cap9Button;
    }
}

