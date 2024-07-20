namespace To_Do_List
{
    partial class AdaugareTaskNou
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Detalii = new System.Windows.Forms.TextBox();
            this.textBox_Nume = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Data_Finalizare = new System.Windows.Forms.DateTimePicker();
            this.button_Salvare = new System.Windows.Forms.Button();
            this.button_Anulare = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data finalizării";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alte detalii";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Detalii);
            this.groupBox1.Controls.Add(this.textBox_Nume);
            this.groupBox1.Controls.Add(this.dateTimePicker_Data_Finalizare);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(168, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 281);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adăugare task nou";
            // 
            // textBox_Detalii
            // 
            this.textBox_Detalii.Location = new System.Drawing.Point(172, 177);
            this.textBox_Detalii.Multiline = true;
            this.textBox_Detalii.Name = "textBox_Detalii";
            this.textBox_Detalii.Size = new System.Drawing.Size(200, 22);
            this.textBox_Detalii.TabIndex = 5;
            // 
            // textBox_Nume
            // 
            this.textBox_Nume.Location = new System.Drawing.Point(172, 54);
            this.textBox_Nume.Name = "textBox_Nume";
            this.textBox_Nume.Size = new System.Drawing.Size(200, 22);
            this.textBox_Nume.TabIndex = 4;
            // 
            // dateTimePicker_Data_Finalizare
            // 
            this.dateTimePicker_Data_Finalizare.Location = new System.Drawing.Point(172, 114);
            this.dateTimePicker_Data_Finalizare.Name = "dateTimePicker_Data_Finalizare";
            this.dateTimePicker_Data_Finalizare.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Data_Finalizare.TabIndex = 3;
            // 
            // button_Salvare
            // 
            this.button_Salvare.Location = new System.Drawing.Point(639, 376);
            this.button_Salvare.Name = "button_Salvare";
            this.button_Salvare.Size = new System.Drawing.Size(113, 44);
            this.button_Salvare.TabIndex = 4;
            this.button_Salvare.Text = "Salvare";
            this.button_Salvare.UseVisualStyleBackColor = true;
            this.button_Salvare.Click += new System.EventHandler(this.button_Salvare_Click);
            // 
            // button_Anulare
            // 
            this.button_Anulare.Location = new System.Drawing.Point(29, 376);
            this.button_Anulare.Name = "button_Anulare";
            this.button_Anulare.Size = new System.Drawing.Size(113, 44);
            this.button_Anulare.TabIndex = 5;
            this.button_Anulare.Text = "Anulare";
            this.button_Anulare.UseVisualStyleBackColor = true;
            this.button_Anulare.Click += new System.EventHandler(this.button_Anulare_Click);
            // 
            // AdaugareTaskNou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 458);
            this.Controls.Add(this.button_Anulare);
            this.Controls.Add(this.button_Salvare);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdaugareTaskNou";
            this.Text = "AdaugareTaskNou";
//            this.Load += new System.EventHandler(this.AdaugareTaskNou_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Detalii;
        private System.Windows.Forms.TextBox textBox_Nume;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Data_Finalizare;
        private System.Windows.Forms.Button button_Salvare;
        private System.Windows.Forms.Button button_Anulare;
    }
}