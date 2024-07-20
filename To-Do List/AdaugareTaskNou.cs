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
    public partial class AdaugareTaskNou : Form
    {
        public AdaugareTaskNou()
        {
            InitializeComponent();
          
        }
        public string Nume { get { return textBox_Nume.Text; } }
        public string Detalii { get { return textBox_Detalii.Text; } }
        public DateTime Data { get { return dateTimePicker_Data_Finalizare.Value; } }
        private void button_Anulare_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button_Salvare_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Detalii.Text) && !string.IsNullOrEmpty(textBox_Nume.Text))
            {
         

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Te rugăm să completezi toate câmpurile.");
            }
        }

        
    }
}
