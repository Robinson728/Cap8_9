
namespace Cap8_9
{
    partial class Ejercicio3Cap8
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
            this.components = new System.ComponentModel.Container();
            this.HoraLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.ActualTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HoraLabel
            // 
            this.HoraLabel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.HoraLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoraLabel.ForeColor = System.Drawing.Color.White;
            this.HoraLabel.Location = new System.Drawing.Point(63, 71);
            this.HoraLabel.Name = "HoraLabel";
            this.HoraLabel.Size = new System.Drawing.Size(376, 60);
            this.HoraLabel.TabIndex = 1;
            this.HoraLabel.Text = "Hora";
            this.HoraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FechaLabel
            // 
            this.FechaLabel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.FechaLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FechaLabel.ForeColor = System.Drawing.Color.White;
            this.FechaLabel.Location = new System.Drawing.Point(63, 120);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(376, 51);
            this.FechaLabel.TabIndex = 2;
            this.FechaLabel.Text = "Fecha";
            this.FechaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ActualTimer
            // 
            this.ActualTimer.Enabled = true;
            this.ActualTimer.Tick += new System.EventHandler(this.ActualTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hacer un programa que muestre la hora del día en formato \r\nAM/FM seguida del año," +
    " el día y el mes actual. ";
            // 
            // Ejercicio3Cap8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.HoraLabel);
            this.Name = "Ejercicio3Cap8";
            this.Text = "Ejercicio3Cap8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HoraLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Timer ActualTimer;
        private System.Windows.Forms.Label label1;
    }
}