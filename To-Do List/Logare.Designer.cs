namespace To_Do_List
{
    partial class Logare
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
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Parola = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Conectare_Manager = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(616, 381);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(119, 36);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(26, 381);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(119, 36);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(90, 28);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(256, 22);
            this.textBox_Email.TabIndex = 4;
            //this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            // 
            // textBox_Parola
            // 
            this.textBox_Parola.Location = new System.Drawing.Point(90, 63);
            this.textBox_Parola.Name = "textBox_Parola";
            this.textBox_Parola.PasswordChar = '*';
            this.textBox_Parola.Size = new System.Drawing.Size(256, 22);
            this.textBox_Parola.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Parola);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Email);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(132, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 138);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date de conectare";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Conectare ca si manager:";
            // 
            // button_Conectare_Manager
            // 
            this.button_Conectare_Manager.Location = new System.Drawing.Point(298, 303);
            this.button_Conectare_Manager.Name = "button_Conectare_Manager";
            this.button_Conectare_Manager.Size = new System.Drawing.Size(88, 23);
            this.button_Conectare_Manager.TabIndex = 11;
            this.button_Conectare_Manager.Text = "Conectare";
            this.button_Conectare_Manager.UseVisualStyleBackColor = true;
            this.button_Conectare_Manager.Click += new System.EventHandler(this.button_Conectare_Manager_Click);
            // 
            // Logare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Conectare_Manager);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Name = "Logare";
            this.Text = "Form1";
          //  this.Load += new System.EventHandler(this.Logare_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Parola;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Conectare_Manager;
    }
}

