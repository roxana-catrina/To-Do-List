namespace To_Do_List
{
    partial class UtilizatorNou
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_ReintroducereParola = new System.Windows.Forms.TextBox();
            this.textBox_Parola = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Prenume = new System.Windows.Forms.TextBox();
            this.textBox_Nume = new System.Windows.Forms.TextBox();
            this.comboBox_Departament = new System.Windows.Forms.ComboBox();
            this.button_Salvare = new System.Windows.Forms.Button();
            this.button_Anulare = new System.Windows.Forms.Button();
            this.CampObligatoriu = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioButton_1 = new System.Windows.Forms.RadioButton();
            this.radioButton_2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CampObligatoriu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parola";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reintrodu parola";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departamentul";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_2);
            this.groupBox1.Controls.Add(this.radioButton_1);
            this.groupBox1.Controls.Add(this.textBox_ReintroducereParola);
            this.groupBox1.Controls.Add(this.textBox_Parola);
            this.groupBox1.Controls.Add(this.textBox_Email);
            this.groupBox1.Controls.Add(this.textBox_Prenume);
            this.groupBox1.Controls.Add(this.textBox_Nume);
            this.groupBox1.Controls.Add(this.comboBox_Departament);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(206, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 309);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utilizator nou";
//            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_ReintroducereParola
            // 
            this.textBox_ReintroducereParola.Location = new System.Drawing.Point(152, 188);
            this.textBox_ReintroducereParola.Name = "textBox_ReintroducereParola";
            this.textBox_ReintroducereParola.PasswordChar = '*';
            this.textBox_ReintroducereParola.Size = new System.Drawing.Size(121, 22);
            this.textBox_ReintroducereParola.TabIndex = 11;
            // 
            // textBox_Parola
            // 
            this.textBox_Parola.Location = new System.Drawing.Point(152, 152);
            this.textBox_Parola.Name = "textBox_Parola";
            this.textBox_Parola.PasswordChar = '*';
            this.textBox_Parola.Size = new System.Drawing.Size(121, 22);
            this.textBox_Parola.TabIndex = 10;
            this.textBox_Parola.TextChanged += new System.EventHandler(this.textBox_Parola_TextChanged);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Enabled = false;
            this.textBox_Email.Location = new System.Drawing.Point(152, 114);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(229, 22);
            this.textBox_Email.TabIndex = 9;
            // 
            // textBox_Prenume
            // 
            this.textBox_Prenume.Location = new System.Drawing.Point(152, 79);
            this.textBox_Prenume.Name = "textBox_Prenume";
            this.textBox_Prenume.Size = new System.Drawing.Size(121, 22);
            this.textBox_Prenume.TabIndex = 8;
            this.textBox_Prenume.TextChanged += new System.EventHandler(this.textBox_Prenume_TextChanged);
            // 
            // textBox_Nume
            // 
            this.textBox_Nume.Location = new System.Drawing.Point(152, 39);
            this.textBox_Nume.Name = "textBox_Nume";
            this.textBox_Nume.Size = new System.Drawing.Size(121, 22);
            this.textBox_Nume.TabIndex = 7;
            this.textBox_Nume.TextChanged += new System.EventHandler(this.textBox_Nume_TextChanged);
            // 
            // comboBox_Departament
            // 
            this.comboBox_Departament.FormattingEnabled = true;
            this.comboBox_Departament.Items.AddRange(new object[] {
            "Financiar",
            "Producție",
            "Vânzări",
            "Resurse Umane"});
            this.comboBox_Departament.Location = new System.Drawing.Point(152, 234);
            this.comboBox_Departament.Name = "comboBox_Departament";
            this.comboBox_Departament.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Departament.TabIndex = 6;
            // 
            // button_Salvare
            // 
            this.button_Salvare.Location = new System.Drawing.Point(615, 373);
            this.button_Salvare.Name = "button_Salvare";
            this.button_Salvare.Size = new System.Drawing.Size(160, 53);
            this.button_Salvare.TabIndex = 7;
            this.button_Salvare.Text = "Salvare";
            this.button_Salvare.UseVisualStyleBackColor = true;
            this.button_Salvare.Click += new System.EventHandler(this.button_Salvare_Click);
            // 
            // button_Anulare
            // 
            this.button_Anulare.Location = new System.Drawing.Point(34, 373);
            this.button_Anulare.Name = "button_Anulare";
            this.button_Anulare.Size = new System.Drawing.Size(160, 53);
            this.button_Anulare.TabIndex = 8;
            this.button_Anulare.Text = "Anulare";
            this.button_Anulare.UseVisualStyleBackColor = true;
            // 
            // CampObligatoriu
            // 
            this.CampObligatoriu.ContainerControl = this;
            // 
            // radioButton_1
            // 
            this.radioButton_1.AutoSize = true;
            this.radioButton_1.Location = new System.Drawing.Point(292, 153);
            this.radioButton_1.Name = "radioButton_1";
            this.radioButton_1.Size = new System.Drawing.Size(17, 16);
            this.radioButton_1.TabIndex = 12;
            this.radioButton_1.TabStop = true;
            this.radioButton_1.UseVisualStyleBackColor = true;
            this.radioButton_1.CheckedChanged += new System.EventHandler(this.radioButton_1_CheckedChanged);
            // 
            // radioButton_2
            // 
            this.radioButton_2.AutoSize = true;
            this.radioButton_2.Location = new System.Drawing.Point(292, 188);
            this.radioButton_2.Name = "radioButton_2";
            this.radioButton_2.Size = new System.Drawing.Size(17, 16);
            this.radioButton_2.TabIndex = 13;
            this.radioButton_2.TabStop = true;
            this.radioButton_2.UseVisualStyleBackColor = true;
            this.radioButton_2.CheckedChanged += new System.EventHandler(this.radioButton_2_CheckedChanged);
            // 
            // UtilizatorNou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Anulare);
            this.Controls.Add(this.button_Salvare);
            this.Controls.Add(this.groupBox1);
            this.Name = "UtilizatorNou";
            this.Text = "UtilizatorNou";
         //   this.Load += new System.EventHandler(this.UtilizatorNou_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CampObligatoriu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_ReintroducereParola;
        private System.Windows.Forms.TextBox textBox_Parola;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Prenume;
        private System.Windows.Forms.TextBox textBox_Nume;
        private System.Windows.Forms.ComboBox comboBox_Departament;
        private System.Windows.Forms.Button button_Salvare;
        private System.Windows.Forms.Button button_Anulare;
        private System.Windows.Forms.ErrorProvider CampObligatoriu;
        private System.Windows.Forms.RadioButton radioButton_2;
        private System.Windows.Forms.RadioButton radioButton_1;
    }
}