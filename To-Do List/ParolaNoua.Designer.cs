namespace To_Do_List
{
    partial class ParolaNoua
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ParolaNoua = new System.Windows.Forms.TextBox();
            this.textBox_ParolaNoua1 = new System.Windows.Forms.TextBox();
            this.button_Salvare = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.radioButton_1 = new System.Windows.Forms.RadioButton();
            this.radioButton_2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parolă nouă";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reintroduceți parola nouă";
            // 
            // textBox_ParolaNoua
            // 
            this.textBox_ParolaNoua.Location = new System.Drawing.Point(337, 165);
            this.textBox_ParolaNoua.Name = "textBox_ParolaNoua";
            this.textBox_ParolaNoua.PasswordChar = '*';
            this.textBox_ParolaNoua.Size = new System.Drawing.Size(201, 22);
            this.textBox_ParolaNoua.TabIndex = 4;
            this.textBox_ParolaNoua.TextChanged += new System.EventHandler(this.textBox_ParolaNoua_TextChanged);
            // 
            // textBox_ParolaNoua1
            // 
            this.textBox_ParolaNoua1.Location = new System.Drawing.Point(337, 223);
            this.textBox_ParolaNoua1.Name = "textBox_ParolaNoua1";
            this.textBox_ParolaNoua1.PasswordChar = '*';
            this.textBox_ParolaNoua1.Size = new System.Drawing.Size(201, 22);
            this.textBox_ParolaNoua1.TabIndex = 5;
            // 
            // button_Salvare
            // 
            this.button_Salvare.Location = new System.Drawing.Point(604, 358);
            this.button_Salvare.Name = "button_Salvare";
            this.button_Salvare.Size = new System.Drawing.Size(116, 48);
            this.button_Salvare.TabIndex = 6;
            this.button_Salvare.Text = "Salvare";
            this.button_Salvare.UseVisualStyleBackColor = true;
            this.button_Salvare.Click += new System.EventHandler(this.button_Salvare_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(44, 358);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(116, 48);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // radioButton_1
            // 
            this.radioButton_1.AutoSize = true;
            this.radioButton_1.Location = new System.Drawing.Point(553, 168);
            this.radioButton_1.Name = "radioButton_1";
            this.radioButton_1.Size = new System.Drawing.Size(17, 16);
            this.radioButton_1.TabIndex = 8;
            this.radioButton_1.UseVisualStyleBackColor = true;
            this.radioButton_1.CheckedChanged += new System.EventHandler(this.radioButton_1_CheckedChanged);
            // 
            // radioButton_2
            // 
            this.radioButton_2.AutoSize = true;
            this.radioButton_2.Location = new System.Drawing.Point(553, 229);
            this.radioButton_2.Name = "radioButton_2";
            this.radioButton_2.Size = new System.Drawing.Size(17, 16);
            this.radioButton_2.TabIndex = 9;
            this.radioButton_2.UseVisualStyleBackColor = true;
            this.radioButton_2.CheckedChanged += new System.EventHandler(this.radioButton_2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(369, 272);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Afișare parolă";
            // 
            // ParolaNoua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton_2);
            this.Controls.Add(this.radioButton_1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Salvare);
            this.Controls.Add(this.textBox_ParolaNoua1);
            this.Controls.Add(this.textBox_ParolaNoua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ParolaNoua";
            this.Text = "ParolaNoua";
            this.Load += new System.EventHandler(this.ParolaNoua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ParolaNoua;
        private System.Windows.Forms.TextBox textBox_ParolaNoua1;
        private System.Windows.Forms.Button button_Salvare;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.RadioButton radioButton_1;
        private System.Windows.Forms.RadioButton radioButton_2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
    }
}