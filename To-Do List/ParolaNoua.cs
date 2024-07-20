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
    public partial class ParolaNoua : Form
    {   private UtilizatorNou un;
        string email_utilizator;
        private Logare l;
        string parola;
        public ParolaNoua(Logare log)
        {
            InitializeComponent();
            un= new UtilizatorNou();
            this.l = log;
            email_utilizator = log.get_email;
            parola = log.get_password;
        }

        public ParolaNoua()
        {
            InitializeComponent();
            un = new UtilizatorNou();
        }
        void modificare_Parola(string email, string parola_noua)
        {

            string tempFile = Path.GetTempFileName();


            using (StreamWriter writer = new StreamWriter(tempFile))
            using (StreamReader reader = new StreamReader("Email_Parole_Utilizatori.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    char delimitator = ' ';
                    int index = line.IndexOf(delimitator);
                    string email1 = line.Substring(0, index);
                    string parola = line.Substring(index + 1);
                    if (email.Trim() == email1.Trim())
                    {
                        writer.WriteLine(email1.Trim() + " " + parola_noua);
                    }
                    else writer.WriteLine(line);

                    line = reader.ReadLine();

                }
            }

            File.Delete("Email_Parole_Utilizatori.txt");
            File.Move(tempFile, "Email_Parole_Utilizatori.txt");
        }





        private void button_Salvare_Click(object sender, EventArgs e)
        {  
            if(!(string.IsNullOrEmpty(textBox_ParolaNoua.Text) && string.IsNullOrEmpty(textBox_ParolaNoua1.Text) ))
            {
              
                bool da = un.ParolaCorecta(textBox_ParolaNoua.Text);
                if (da == true)
                {

                    if (textBox_ParolaNoua1.Text.Trim() == parola.Trim())
                    {
                        MessageBox.Show("Ați introdus o parolă veche!", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                      else

                       if ( textBox_ParolaNoua1.Text == textBox_ParolaNoua.Text)
                         {
                             this.DialogResult = DialogResult.OK;
                             modificare_Parola(email_utilizator, textBox_ParolaNoua.Text);
                             MessageBox.Show("Datele au fost salvate cu succes", "Informații", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             this.Close();
               


                          }
                            else
                              if( textBox_ParolaNoua1.Text != textBox_ParolaNoua.Text)
                                {
                                   MessageBox.Show("Parolele nu corespund!","Atenție!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                 }
           
            } 
              else
                {
                    MessageBox.Show("Parola trebuie sa contina  cel putin 3 litere si cel putin o majuscula si cel putin 3 caractere care nu sunt litere", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Completeaza toate campurile!", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void ParolaNoua_Load(object sender, EventArgs e)
        {

        }

        private void textBox_ParolaNoua_TextChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(textBox_ParolaNoua, "Parola trebuie sa contina  cel putin 3 litere si cel putin o majuscula si cel putin 3 caractere care nu sunt litere");
        }

        private void radioButton_1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_1.Checked) {
                textBox_ParolaNoua.PasswordChar = '\0';
            }
            else
            {
                textBox_ParolaNoua.PasswordChar = '*';
            }

        }

        private void radioButton_2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_2.Checked)
            {
                textBox_ParolaNoua1.PasswordChar = '\0';
            }
            else
            {
                textBox_ParolaNoua1.PasswordChar = '*';
            }
        }
    }
}
