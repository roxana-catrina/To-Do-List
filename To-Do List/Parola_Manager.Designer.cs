namespace To_Do_List
{
    partial class Parola_Manager
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
            this.textBox_Parola_Unica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Conectare = new System.Windows.Forms.Button();
            this.button_Anulare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Parola_Unica
            // 
            this.textBox_Parola_Unica.Location = new System.Drawing.Point(225, 158);
            this.textBox_Parola_Unica.Name = "textBox_Parola_Unica";
            this.textBox_Parola_Unica.Size = new System.Drawing.Size(249, 22);
            this.textBox_Parola_Unica.TabIndex = 0;
            this.textBox_Parola_Unica.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vă rugăm introduceți parola unică:";
            // 
            // button_Conectare
            // 
            this.button_Conectare.Location = new System.Drawing.Point(587, 359);
            this.button_Conectare.Name = "button_Conectare";
            this.button_Conectare.Size = new System.Drawing.Size(138, 47);
            this.button_Conectare.TabIndex = 2;
            this.button_Conectare.Text = "Conectare";
            this.button_Conectare.UseVisualStyleBackColor = true;
            this.button_Conectare.Click += new System.EventHandler(this.button_Conectare_Click);
            // 
            // button_Anulare
            // 
            this.button_Anulare.Location = new System.Drawing.Point(62, 359);
            this.button_Anulare.Name = "button_Anulare";
            this.button_Anulare.Size = new System.Drawing.Size(138, 47);
            this.button_Anulare.TabIndex = 3;
            this.button_Anulare.Text = "Anulare";
            this.button_Anulare.UseVisualStyleBackColor = true;
            this.button_Anulare.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "parola este 1";
            // 
            // Parola_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Anulare);
            this.Controls.Add(this.button_Conectare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Parola_Unica);
            this.Name = "Parola_Manager";
            this.Text = "Parola_Manager";
            this.Load += new System.EventHandler(this.Parola_Manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Parola_Unica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Conectare;
        private System.Windows.Forms.Button button_Anulare;
        private System.Windows.Forms.Label label2;
    }
}