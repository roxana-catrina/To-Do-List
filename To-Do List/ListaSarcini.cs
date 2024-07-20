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
    public partial class ListaSarcini : Form
    {
        string utilizator_email;
        string utilizator_nume;
        string utilizator_prenume;
        List<string> taskuri = null;
        string cale_utilizator_curent;
        string email ;
        private Logare f;
        public ListaSarcini(Logare ff)
        {
            InitializeComponent();
            this.f = ff;
          
        }

        public ListaSarcini()
        {
            InitializeComponent();
          
        }
          //Populare flowLayoutPanel uri
        private void IncarcaSarcini()
        {
            flowLayoutPanel1_toate.Controls.Clear();
            flowLayoutPanel_48h.Controls.Clear();
            flowLayoutPanel_TaskSelectat.Controls.Clear();
            flowLayoutPanel_neindeplinite.Controls.Clear();
            string numeTask;
            string dataTask;
            string comentariiTask;
            Task task = null;
            taskuri = Directory.EnumerateFiles(cale_utilizator_curent).ToList();
            StreamReader reader = null; ;
            foreach (string t in taskuri)
            {
                 reader = new StreamReader(t);

                    numeTask = reader.ReadLine();
                    dataTask = reader.ReadLine();
                    comentariiTask = reader.ReadLine();
                reader.Close();

                task = new Task(numeTask, Convert.ToDateTime(dataTask), comentariiTask);
                Button btn = new Button
                {
                    Text = numeTask,
                    Width = 150,
                    Tag = task
                };
                flowLayoutPanel1_toate.Controls.Add(btn);
                if (Convert.ToDateTime(dataTask) - DateTime.Now < TimeSpan.FromHours(48))
                {

                    Button btn48h = new Button
                    {
                        Text = numeTask,
                        Width = 200,
                        Tag = task
                    };
                    btn48h.Click += Click_buton;
                    flowLayoutPanel_48h.Controls.Add(btn48h);
                }
                if (DateTime.Now > Convert.ToDateTime(dataTask))
                {
                    Button btn0h = new Button
                    {
                        Text = numeTask,
                        Width = 200,
                        Tag = task
                    };
                    btn0h.Click += Click_buton;
                    flowLayoutPanel_neindeplinite.Controls.Add(btn0h);
                }

                btn.Click += Click_buton;
            }
            
            
        }


        private void ListaSarcini_Load(object sender, EventArgs e)
        {
           //email furnizat de la logare
            utilizator_email = f.get_email;
            int index = 0;
            char delimitator = '_';
           //Nume si prenume din email
            index=utilizator_email.IndexOf(delimitator);
            utilizator_prenume=utilizator_email.Substring(0,index);
            utilizator_email = utilizator_email.Substring(index + 1);
            int  index1 = utilizator_email.IndexOf(delimitator);
            utilizator_nume = utilizator_email.Substring(0, index1);
            List<string> departamente= Directory.EnumerateDirectories("Departament").ToList();
            foreach (string d in departamente)
            {
                List<string> angajati = Directory.EnumerateDirectories(d).ToList();

                foreach (string a in angajati)
                {
                    string nume_angajat_complet = Path.GetFileNameWithoutExtension(a);
                    delimitator = ' ';
                    index = nume_angajat_complet.IndexOf(delimitator);
                    string prenume = nume_angajat_complet.Substring(0, index);
                    string nume = nume_angajat_complet.Substring(index + 1);
                    if (prenume.Trim() == utilizator_prenume.Trim() && utilizator_nume.Trim() == nume.Trim())
                    {
                        cale_utilizator_curent = a;
                        IncarcaSarcini();

                    }
                }
            }
        }
       
        private void Click_buton(object sender, EventArgs e)
        {
            listBox_Detalii.Items.Clear();
            Button btn = (Button)sender;
            Task t = (Task)btn.Tag;
            listBox_Detalii.Items.Add("Nume: "+ t.NumeTask);
            listBox_Detalii.Items.Add("Data finalizare: " + t.DataTask);
            listBox_Detalii.Items.Add("Cometarii: " + t.ComentariiTask);
            flowLayoutPanel_TaskSelectat.Controls.Clear();
            Button btnn = new Button
            {
                Text = btn.Text,
                Width = 150,
                Tag = btn.Tag,
            };
            flowLayoutPanel_TaskSelectat.Controls.Add(btnn);

        }


        private FlowLayoutPanel Actualizare_Butoane(FlowLayoutPanel x, Button btn)
        {
           

            foreach (Control control in x.Controls)
            {
                if (control is Button && control.Text == btn.Text)
                {
                    x.Controls.Remove(control);
                }
            }

           
            return x;
        }

        //stergere task uri terminate
        private void button_Finalizare_Click(object sender, EventArgs e)  
        {



            if (flowLayoutPanel_TaskSelectat.Controls.Count > 0)
            {
                Button butonSelectat = flowLayoutPanel_TaskSelectat.Controls[0] as Button;
                Task task = butonSelectat.Tag as Task;

                if (task != null)
                {
                    try
                    {
                        foreach (string t in taskuri)
                        {
                            string numeFisier = Path.GetFileNameWithoutExtension(t);
                            if (numeFisier == task.NumeTask)
                            {
                                File.Delete(t);
                                flowLayoutPanel1_toate = Actualizare_Butoane(flowLayoutPanel1_toate, butonSelectat);
                                flowLayoutPanel_48h = Actualizare_Butoane(flowLayoutPanel_48h, butonSelectat);
                                flowLayoutPanel_neindeplinite=Actualizare_Butoane(flowLayoutPanel_neindeplinite, butonSelectat);
                                flowLayoutPanel_TaskSelectat.Controls.Remove(butonSelectat);
                                listBox_Detalii.Items.Clear();
                                flowLayoutPanel1_toate.Refresh();
                                flowLayoutPanel_48h.Refresh();
                                flowLayoutPanel_TaskSelectat.Refresh();
                                flowLayoutPanel_neindeplinite.Refresh();
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Eroare: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nu ai selectat un task.");
            }
        }


        private void button_AdaugareTask_Click(object sender, EventArgs e)
        {
            AdaugareTaskNou f = new AdaugareTaskNou();
            f.ShowDialog();
            if(f.DialogResult == DialogResult.OK)
            {
                
                Task task = new Task(f.Nume, f.Data, f.Detalii);
                StreamWriter writer= new StreamWriter(cale_utilizator_curent+"\\"+f.Nume);
                writer.WriteLine(f.Nume);
                writer.WriteLine(f.Data.ToString());
                writer.WriteLine(f.Detalii);
                writer.Close();
                IncarcaSarcini();
            }
            
        }

        private void button_Delogare_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_SchimbareParola_Click(object sender, EventArgs e)
        {
            ParolaNoua pn= new ParolaNoua(f);
            pn.ShowDialog(this);
        }
    }
}
