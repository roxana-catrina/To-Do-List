using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Parola_Manager : Form
    {
        public Parola_Manager()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button_Conectare_Click(object sender, EventArgs e)
        {
            if (textBox_Parola_Unica.Text.Trim() == "1")
            {
                Manager f = new Manager();
                f.ShowDialog();
                textBox_Parola_Unica.Clear();
            }
            else
                MessageBox.Show("Introdu o parola corectă!", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Parola_Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
