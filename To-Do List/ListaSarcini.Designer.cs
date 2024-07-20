namespace To_Do_List
{
    partial class ListaSarcini
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
            this.flowLayoutPanel_48h = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1_toate = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Detalii = new System.Windows.Forms.ListBox();
            this.button_AdaugareTask = new System.Windows.Forms.Button();
            this.button_Finalizare = new System.Windows.Forms.Button();
            this.flowLayoutPanel_TaskSelectat = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Delogare = new System.Windows.Forms.Button();
            this.button_SchimbareParola = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_neindeplinite = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "În următoarele 48h";
            // 
            // flowLayoutPanel_48h
            // 
            this.flowLayoutPanel_48h.AutoScroll = true;
            this.flowLayoutPanel_48h.Location = new System.Drawing.Point(26, 61);
            this.flowLayoutPanel_48h.Name = "flowLayoutPanel_48h";
            this.flowLayoutPanel_48h.Size = new System.Drawing.Size(223, 222);
            this.flowLayoutPanel_48h.TabIndex = 1;
            // 
            // flowLayoutPanel1_toate
            // 
            this.flowLayoutPanel1_toate.AutoScroll = true;
            this.flowLayoutPanel1_toate.Location = new System.Drawing.Point(309, 61);
            this.flowLayoutPanel1_toate.Name = "flowLayoutPanel1_toate";
            this.flowLayoutPanel1_toate.Size = new System.Drawing.Size(223, 222);
            this.flowLayoutPanel1_toate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toate";
            // 
            // listBox_Detalii
            // 
            this.listBox_Detalii.FormattingEnabled = true;
            this.listBox_Detalii.ItemHeight = 16;
            this.listBox_Detalii.Location = new System.Drawing.Point(626, 191);
            this.listBox_Detalii.MultiColumn = true;
            this.listBox_Detalii.Name = "listBox_Detalii";
            this.listBox_Detalii.ScrollAlwaysVisible = true;
            this.listBox_Detalii.Size = new System.Drawing.Size(277, 276);
            this.listBox_Detalii.TabIndex = 4;
            // 
            // button_AdaugareTask
            // 
            this.button_AdaugareTask.Location = new System.Drawing.Point(445, 289);
            this.button_AdaugareTask.Name = "button_AdaugareTask";
            this.button_AdaugareTask.Size = new System.Drawing.Size(144, 54);
            this.button_AdaugareTask.TabIndex = 5;
            this.button_AdaugareTask.Text = "Adaugă task nou";
            this.button_AdaugareTask.UseVisualStyleBackColor = true;
            this.button_AdaugareTask.Click += new System.EventHandler(this.button_AdaugareTask_Click);
            // 
            // button_Finalizare
            // 
            this.button_Finalizare.Location = new System.Drawing.Point(445, 353);
            this.button_Finalizare.Name = "button_Finalizare";
            this.button_Finalizare.Size = new System.Drawing.Size(144, 54);
            this.button_Finalizare.TabIndex = 5;
            this.button_Finalizare.Text = "Finalizare task";
            this.button_Finalizare.UseVisualStyleBackColor = true;
            this.button_Finalizare.Click += new System.EventHandler(this.button_Finalizare_Click);
            // 
            // flowLayoutPanel_TaskSelectat
            // 
            this.flowLayoutPanel_TaskSelectat.AutoScroll = true;
            this.flowLayoutPanel_TaskSelectat.Location = new System.Drawing.Point(613, 61);
            this.flowLayoutPanel_TaskSelectat.Name = "flowLayoutPanel_TaskSelectat";
            this.flowLayoutPanel_TaskSelectat.Size = new System.Drawing.Size(201, 57);
            this.flowLayoutPanel_TaskSelectat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vă uitați la taskul:";
            // 
            // button_Delogare
            // 
            this.button_Delogare.Location = new System.Drawing.Point(445, 413);
            this.button_Delogare.Name = "button_Delogare";
            this.button_Delogare.Size = new System.Drawing.Size(144, 54);
            this.button_Delogare.TabIndex = 8;
            this.button_Delogare.Text = "Delogare";
            this.button_Delogare.UseVisualStyleBackColor = true;
            this.button_Delogare.Click += new System.EventHandler(this.button_Delogare_Click);
            // 
            // button_SchimbareParola
            // 
            this.button_SchimbareParola.Location = new System.Drawing.Point(785, 483);
            this.button_SchimbareParola.Name = "button_SchimbareParola";
            this.button_SchimbareParola.Size = new System.Drawing.Size(133, 38);
            this.button_SchimbareParola.TabIndex = 9;
            this.button_SchimbareParola.Text = "Schimbă parola";
            this.button_SchimbareParola.UseVisualStyleBackColor = true;
            this.button_SchimbareParola.Click += new System.EventHandler(this.button_SchimbareParola_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Neindeplinite";
            // 
            // flowLayoutPanel_neindeplinite
            // 
            this.flowLayoutPanel_neindeplinite.Location = new System.Drawing.Point(12, 330);
            this.flowLayoutPanel_neindeplinite.Name = "flowLayoutPanel_neindeplinite";
            this.flowLayoutPanel_neindeplinite.Size = new System.Drawing.Size(317, 151);
            this.flowLayoutPanel_neindeplinite.TabIndex = 11;
            // 
            // ListaSarcini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 533);
            this.Controls.Add(this.flowLayoutPanel_neindeplinite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_SchimbareParola);
            this.Controls.Add(this.button_Delogare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel_TaskSelectat);
            this.Controls.Add(this.button_Finalizare);
            this.Controls.Add(this.button_AdaugareTask);
            this.Controls.Add(this.listBox_Detalii);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1_toate);
            this.Controls.Add(this.flowLayoutPanel_48h);
            this.Controls.Add(this.label1);
            this.Name = "ListaSarcini";
            this.Text = "ListaSarcini";
            this.Load += new System.EventHandler(this.ListaSarcini_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_48h;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1_toate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Detalii;
        private System.Windows.Forms.Button button_AdaugareTask;
        private System.Windows.Forms.Button button_Finalizare;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_TaskSelectat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Delogare;
        private System.Windows.Forms.Button button_SchimbareParola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_neindeplinite;
    }
}