namespace To_Do_List
{
    partial class Manager
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
            this.treeView_Angajati = new System.Windows.Forms.TreeView();
            this.propertyGrid_Angajati = new System.Windows.Forms.PropertyGrid();
            this.button_Delogare = new System.Windows.Forms.Button();
            this.button_Stergere_Angajat = new System.Windows.Forms.Button();
            this.button_Adaugare_Angajat = new System.Windows.Forms.Button();
            this.button_Adaugare_Sarcina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView_Angajati
            // 
            this.treeView_Angajati.Location = new System.Drawing.Point(25, 41);
            this.treeView_Angajati.Name = "treeView_Angajati";
            this.treeView_Angajati.Size = new System.Drawing.Size(204, 293);
            this.treeView_Angajati.TabIndex = 0;
            this.treeView_Angajati.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Angajati_AfterSelect);
            // 
            // propertyGrid_Angajati
            // 
            this.propertyGrid_Angajati.Location = new System.Drawing.Point(491, 23);
            this.propertyGrid_Angajati.Name = "propertyGrid_Angajati";
            this.propertyGrid_Angajati.Size = new System.Drawing.Size(280, 338);
            this.propertyGrid_Angajati.TabIndex = 1;
            this.propertyGrid_Angajati.Click += new System.EventHandler(this.propertyGrid_Angajati_Click);
            // 
            // button_Delogare
            // 
            this.button_Delogare.Location = new System.Drawing.Point(601, 384);
            this.button_Delogare.Name = "button_Delogare";
            this.button_Delogare.Size = new System.Drawing.Size(146, 48);
            this.button_Delogare.TabIndex = 2;
            this.button_Delogare.Text = "Delogare";
            this.button_Delogare.UseVisualStyleBackColor = true;
            this.button_Delogare.Click += new System.EventHandler(this.button_Delogare_Click);
            // 
            // button_Stergere_Angajat
            // 
            this.button_Stergere_Angajat.Location = new System.Drawing.Point(280, 58);
            this.button_Stergere_Angajat.Name = "button_Stergere_Angajat";
            this.button_Stergere_Angajat.Size = new System.Drawing.Size(146, 48);
            this.button_Stergere_Angajat.TabIndex = 3;
            this.button_Stergere_Angajat.Text = "Stergere angajat";
            this.button_Stergere_Angajat.UseVisualStyleBackColor = true;
            this.button_Stergere_Angajat.Click += new System.EventHandler(this.button_Stergere_Angajat_Click);
            // 
            // button_Adaugare_Angajat
            // 
            this.button_Adaugare_Angajat.Location = new System.Drawing.Point(280, 161);
            this.button_Adaugare_Angajat.Name = "button_Adaugare_Angajat";
            this.button_Adaugare_Angajat.Size = new System.Drawing.Size(146, 48);
            this.button_Adaugare_Angajat.TabIndex = 4;
            this.button_Adaugare_Angajat.Text = "Adaugare angajat";
            this.button_Adaugare_Angajat.UseVisualStyleBackColor = true;
            this.button_Adaugare_Angajat.Click += new System.EventHandler(this.button_Adaugare_Angajat_Click);
            // 
            // button_Adaugare_Sarcina
            // 
            this.button_Adaugare_Sarcina.Location = new System.Drawing.Point(280, 273);
            this.button_Adaugare_Sarcina.Name = "button_Adaugare_Sarcina";
            this.button_Adaugare_Sarcina.Size = new System.Drawing.Size(146, 48);
            this.button_Adaugare_Sarcina.TabIndex = 5;
            this.button_Adaugare_Sarcina.Text = "Adaugare sarcina";
            this.button_Adaugare_Sarcina.UseVisualStyleBackColor = true;
            this.button_Adaugare_Sarcina.Click += new System.EventHandler(this.button_Adaugare_Sarcina_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.button_Adaugare_Sarcina);
            this.Controls.Add(this.button_Adaugare_Angajat);
            this.Controls.Add(this.button_Stergere_Angajat);
            this.Controls.Add(this.button_Delogare);
            this.Controls.Add(this.propertyGrid_Angajati);
            this.Controls.Add(this.treeView_Angajati);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_Angajati;
        private System.Windows.Forms.PropertyGrid propertyGrid_Angajati;
        private System.Windows.Forms.Button button_Delogare;
        private System.Windows.Forms.Button button_Stergere_Angajat;
        private System.Windows.Forms.Button button_Adaugare_Angajat;
        private System.Windows.Forms.Button button_Adaugare_Sarcina;
    }
}