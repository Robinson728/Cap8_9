
namespace Cap8_9
{
    partial class Ejercicio5Cap8
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
            this.Cadena1TextBox = new System.Windows.Forms.TextBox();
            this.Cadena2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.ResultadoButton = new System.Windows.Forms.Button();
            this.Resultado2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cadena1TextBox
            // 
            this.Cadena1TextBox.Location = new System.Drawing.Point(85, 78);
            this.Cadena1TextBox.Name = "Cadena1TextBox";
            this.Cadena1TextBox.Size = new System.Drawing.Size(161, 23);
            this.Cadena1TextBox.TabIndex = 0;
            // 
            // Cadena2TextBox
            // 
            this.Cadena2TextBox.Location = new System.Drawing.Point(85, 123);
            this.Cadena2TextBox.Name = "Cadena2TextBox";
            this.Cadena2TextBox.Size = new System.Drawing.Size(161, 23);
            this.Cadena2TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadena #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cadena #2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hacer un programa que le solicite al usuario dos\r\ncadenas y luego las muestre en " +
    "orden alfabético.";
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(36, 193);
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.Size = new System.Drawing.Size(161, 23);
            this.ResultadoTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultado";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(115, 244);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(82, 33);
            this.NuevoButton.TabIndex = 7;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // ResultadoButton
            // 
            this.ResultadoButton.Location = new System.Drawing.Point(217, 244);
            this.ResultadoButton.Name = "ResultadoButton";
            this.ResultadoButton.Size = new System.Drawing.Size(82, 33);
            this.ResultadoButton.TabIndex = 8;
            this.ResultadoButton.Text = "Resultado";
            this.ResultadoButton.UseVisualStyleBackColor = true;
            this.ResultadoButton.Click += new System.EventHandler(this.ResultadoButton_Click);
            // 
            // Resultado2TextBox
            // 
            this.Resultado2TextBox.Location = new System.Drawing.Point(234, 193);
            this.Resultado2TextBox.Name = "Resultado2TextBox";
            this.Resultado2TextBox.Size = new System.Drawing.Size(161, 23);
            this.Resultado2TextBox.TabIndex = 9;
            // 
            // Ejercicio5Cap8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 286);
            this.Controls.Add(this.Resultado2TextBox);
            this.Controls.Add(this.ResultadoButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cadena2TextBox);
            this.Controls.Add(this.Cadena1TextBox);
            this.Name = "Ejercicio5Cap8";
            this.Text = "Ejercicio5Cap8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cadena1TextBox;
        private System.Windows.Forms.TextBox Cadena2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultadoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button ResultadoButton;
        private System.Windows.Forms.TextBox Resultado2TextBox;
    }
}