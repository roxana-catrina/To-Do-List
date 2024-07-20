using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace To_Do_List
{
    public partial class UtilizatorNou : Form
    {  
        public UtilizatorNou()
        {
            InitializeComponent();
        }
       public bool ParolaCorecta(string parola)
        { int litera = 0, cifra = 0, caracter = 0;
            int caracter_majuscula=0;
            foreach(char c in parola)
            {
                if (char.IsDigit(c))
                    cifra++;
                else if (char.IsLetter(c))
                    litera++;
                else
                    caracter++;
                if (char.IsUpper(c))
                    caracter_majuscula = 1;

            }
            if(caracter_majuscula==1 && litera>=3 && caracter+cifra>=3)
                return true;
            else
                return false;
        }
        private bool DouaNumeSauPrenume(string text)     
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length >= 2;
        }
        string PrimulNumePrimulPrenume(string name,string textBox)
        {
            char delimitator = ' ';
            int index = 0;
            index = name.IndexOf(delimitator);
            name = name.Substring(0, index);
            return name;
        }
        private void button_Salvare_Click(object sender, EventArgs e)

        {
            int k = 0;
            CampObligatoriu.Clear();
            if  ( string.IsNullOrEmpty( textBox_Nume.Text ))
            { CampObligatoriu.SetError(textBox_Nume, "Campul trebuie completat");
                k++;
            }
            if (string.IsNullOrEmpty(textBox_Prenume.Text)) 
            { 
                CampObligatoriu.SetError(textBox_Prenume, "Campul trebuie completat");
                k++;
            }
           
            if (comboBox_Departament.SelectedIndex == -1)
            {
                CampObligatoriu.SetError(comboBox_Departament, "Campul trebuie completat");
                k++;
            }
            if (textBox_Parola.Text != textBox_ReintroducereParola.Text)
            {
                CampObligatoriu.SetError(textBox_ReintroducereParola, "Parolele nu corespund");
                CampObligatoriu.SetError(textBox_Parola, "Parolele nu corespund");
                k++;
            }
            if(ParolaCorecta(textBox_Parola.Text)==false)
            {
                CampObligatoriu.SetError(textBox_Parola, "Parola nu indeplineste conditiile");
                k++;
            }
            FileStream fs = new FileStream("Email_Parole_Utilizatori.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs); 
            if (k == 0)
            {
              
                    writer.WriteLine(textBox_Email.Text + " " + textBox_Parola.Text);
                    writer.Close();
                
                 string nume = textBox_Nume.Text.Trim();
                 string prenume = textBox_Prenume.Text.Trim();
               
                if (DouaNumeSauPrenume(textBox_Prenume.Text))
                {
                    prenume = PrimulNumePrimulPrenume(prenume, textBox_Prenume.Text);
                }
                if (DouaNumeSauPrenume(textBox_Nume.Text))
                {
                    nume = PrimulNumePrimulPrenume(nume,textBox_Nume.Text);

                }
               
                Directory.CreateDirectory(Path.Combine("Departament", comboBox_Departament.Text, char.ToUpper(prenume[0]) + prenume.Substring(1) + " " + char.ToUpper(nume[0]) + nume.Substring(1)));
                MessageBox.Show("Datele au fost salvate cu succes!", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            writer.Close() ;
            
        }

        private void textBox_Nume_TextChanged(object sender, EventArgs e)
        {

            string nume = textBox_Nume.Text.Trim();
            string prenume = textBox_Prenume.Text.Trim();


            if (!(string.IsNullOrEmpty(textBox_Prenume.Text)) && !(string.IsNullOrEmpty(textBox_Nume.Text)))
            {
               
                if (DouaNumeSauPrenume(textBox_Prenume.Text))
                {
                    prenume = PrimulNumePrimulPrenume(prenume, textBox_Prenume.Text);
                }
                if (DouaNumeSauPrenume(textBox_Nume.Text))
                {
                    nume = PrimulNumePrimulPrenume(nume, textBox_Nume.Text);

                }
                textBox_Email.Text = char.ToUpper(prenume[0]) + prenume.Substring(1) + "_" + char.ToUpper(nume[0]) + nume.Substring(1) + "_@gmail.com";
            }
            else
                if (!(string.IsNullOrEmpty(textBox_Nume.Text)) && textBox_Nume.Text.Length>2)
            {
                if (DouaNumeSauPrenume(textBox_Nume.Text))
                {
                    char delimitator = ' ';
                    int index = nume.IndexOf(delimitator);
                    nume = nume.Substring(0, index);
                }
                textBox_Email.Text = prenume + "_" + char.ToUpper(nume[0]) + nume.Substring(1) + "_@gmail.com";
            }
        }
        
       
        private void textBox_Prenume_TextChanged(object sender, EventArgs e)
        {
            string nume = textBox_Nume.Text.Trim();
            string prenume = textBox_Prenume.Text.Trim();

            if (!(string.IsNullOrEmpty(textBox_Prenume.Text)) && !(string.IsNullOrEmpty(textBox_Nume.Text)))
            {
                if (DouaNumeSauPrenume(textBox_Prenume.Text))
                {
                    prenume = PrimulNumePrimulPrenume(prenume, textBox_Prenume.Text);
                }
                if (DouaNumeSauPrenume(textBox_Nume.Text))
                {
                    nume = PrimulNumePrimulPrenume(nume, textBox_Nume.Text);

                }
                textBox_Email.Text = char.ToUpper(prenume[0]) + prenume.Substring(1) + "_" + char.ToUpper(nume[0]) + nume.Substring(1) + "_@gmail.com";
            }
            else
             if (!(string.IsNullOrEmpty(textBox_Prenume.Text)))
            {
                if (DouaNumeSauPrenume(textBox_Prenume.Text)) { 
                    char delimitator = ' ';
                int index = prenume.IndexOf(delimitator);
                prenume = prenume.Substring(0, index);}
                textBox_Email.Text = char.ToUpper(prenume[0]) + prenume.Substring(1) + "_" + nume + "_@gmail.com";
               
            }
        }

        private void textBox_Parola_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(textBox_Parola, "Parola trebuie sa contina  cel putin 3 litere si cel putin o majuscula si cel putin 3 caractere care nu sunt litere");
        }

      
        private void radioButton_1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_1.Checked)
            {
                textBox_Parola.PasswordChar = '\0';
            }
            else
            {
                textBox_Parola.PasswordChar = '*';
            }
        }

        private void radioButton_2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_1.Checked)
            {
               textBox_ReintroducereParola.PasswordChar = '\0';
            }
            else
            {
                textBox_ReintroducereParola.PasswordChar = '*';
            }
        }
    }
}
