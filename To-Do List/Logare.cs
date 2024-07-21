using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Logare : Form
    {

        int k = 0;
        public Logare()
        {
            InitializeComponent();
        }
       public string get_email
        {
            get
            {
                return textBox_Email.Text.Trim();
            }
            set { textBox_Email.Text = value; }
        }
        public string get_password
        {
            get
            {
                return textBox_Parola.Text.Trim();  
            }
            set
            {
                textBox_Parola.Text = value;    
            }
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            
            StreamReader reader = new StreamReader("Email_Parole_Utilizatori.txt");
            string line = reader.ReadLine();
            int contor = 0;
            while (line!=null)
            {
                char delimitator = ' ';
                int index = line.IndexOf(delimitator);
                string email= line.Substring(0, index);
                string parola = line.Substring(index + 1);
                if (email==textBox_Email.Text.Trim() && textBox_Parola.Text.Trim() == parola)
                {
                    contor = 1;
                    this.DialogResult= DialogResult.OK;
                   ListaSarcini f=new ListaSarcini(this);
                    get_email = email;
                    get_password = parola;
                    reader.Close();
                    textBox_Parola.Text = " ";
                    f.ShowDialog();
                    textBox_Email.Clear();
                    textBox_Parola.Clear();
                    break;
                }
                else if((email != textBox_Email.Text && textBox_Parola.Text == parola || email == textBox_Email.Text && textBox_Parola.Text != parola) /*&& k==0*/)
                {
                    contor = 1;
                    MessageBox.Show("Email-ul sau parola incorect","Atentie",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    break;
                }
                //if(k == 0)
                line=reader.ReadLine();
                
            }
            if (contor == 0)
            { 
                string message = "Contul nu există";
                string title = "Cont neexistent";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    textBox_Email.Clear();
                    textBox_Parola.Clear();
                

                
            }
             
           reader.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button_Conectare_Manager_Click(object sender, EventArgs e)
        {
            Parola_Manager f=new Parola_Manager();
            f.ShowDialog();
        }

       
    }
}
