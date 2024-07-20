using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace To_Do_List
{
    public partial class Manager : Form
    {
        List<Clasa_Sarcina_Manager> clasa_Sarcina_Managers = new List<Clasa_Sarcina_Manager>();
        List<string> toti_angajatii=new List<string>();
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            //adaugă un nod nou în rădăcină
            List<string> departamente = Directory.EnumerateDirectories("Departament").ToList();
            string numeTask;
            string dataTask;
            string comentariiTask;
            TreeNode childNode1;
            TreeNode childNode;
            Task task;
            Clasa_Sarcina_Manager csm;
            TreeNode parentNode;
            foreach (string d in departamente)
            {
                parentNode = new TreeNode();
                parentNode.Name = Path.GetFileNameWithoutExtension(d);
                parentNode.Text = Path.GetFileNameWithoutExtension(d);
                treeView_Angajati.Nodes.Add(parentNode);
                List<string> angajati = Directory.EnumerateDirectories(d).ToList();

                foreach (string a in angajati)
                {
                    toti_angajatii.Add(a);
                    //  adaugă un nod fiu la nodul creat anterior
                    childNode = new TreeNode();
                    childNode.Name = Path.GetFileNameWithoutExtension(a);
                    childNode.Text = Path.GetFileNameWithoutExtension(a);
                    parentNode.Nodes.Add(childNode);
                    List<string> task_cale = Directory.EnumerateFiles(a).ToList();
                    List<Task> taskuri = new List<Task>();
                    if (task_cale.Count > 0)
                    {
                        foreach (string t in task_cale)
                        {
                            childNode1 = new TreeNode();
                            childNode1.Name = Path.GetFileNameWithoutExtension(t);
                            childNode1.Text = Path.GetFileNameWithoutExtension(t);
                            childNode.Nodes.Add(childNode1);
                            StreamReader reader = new StreamReader(t);
                            numeTask = reader.ReadLine();
                            dataTask = reader.ReadLine();
                            comentariiTask = reader.ReadLine();
                            task = new Task(numeTask, Convert.ToDateTime(dataTask), comentariiTask);
                            taskuri.Add(task);
                            reader.Close();

                        }
                    }
                    csm = new Clasa_Sarcina_Manager(a, taskuri);
                    clasa_Sarcina_Managers.Add(csm);

                }

            }


        }

        private void treeView_Angajati_AfterSelect(object sender, TreeViewEventArgs e)
        {
            List<Task> tasklist = new List<Task>();
            string name = e.Node.Name;
            foreach (Clasa_Sarcina_Manager csm in clasa_Sarcina_Managers)
            {
                tasklist = csm.GetTaskuri();
                foreach (Task task in tasklist)
                {
                    if (name == task.NumeTask)
                        propertyGrid_Angajati.SelectedObject = task;
                }
            }
        }

        private void StergeAngajat(string cale)
        {
            try
            {
                if (Directory.Exists(cale))
                {
                    string[] files = Directory.GetFiles(cale);
                    foreach (string file in files)
                        File.Delete(file);

                    Directory.Delete(cale);

                    MessageBox.Show("Angajatul și fișierele sale au fost șterse cu succes.", "Atenție!", MessageBoxButtons.OK );
                }
                else
                {
                    MessageBox.Show("Directorul angajatului nu există.", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare la ștergerea angajatului: {ex.Message}");
            }
        }
          void ActualizareFisierCuEmailsiParole(string selectedName)
        {

            
            string tempFile = Path.GetTempFileName();
            StreamWriter writer = new StreamWriter(tempFile);
            StreamReader reader = new StreamReader("Email_Parole_Utilizatori.txt");
            try
            {
                
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        char delimitator = ' ';
                        int index = line.IndexOf(delimitator);
                        string utilizator_email = line.Substring(0, index);

                        delimitator = '_';
                        index = utilizator_email.IndexOf(delimitator);
                        string utilizator_prenume = utilizator_email.Substring(0, index);
                        utilizator_email = utilizator_email.Substring(index + 1);
                        int index1 = utilizator_email.IndexOf(delimitator);
                        string utilizator_nume = utilizator_email.Substring(0, index1);

                        if (selectedName != utilizator_prenume + " " + utilizator_nume)
                        {
                            writer.WriteLine(line);
                        }
                    
                }

                File.Delete("Email_Parole_Utilizatori.txt");
                File.Move(tempFile, "Email_Parole_Utilizatori.txt");
                reader.Close();
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la actualizarea fișierului: {ex.Message}");
            }


        }
        private void button_Stergere_Angajat_Click(object sender, EventArgs e)
        {
            if (treeView_Angajati.SelectedNode != null)
            {
                TreeNode selectedNode = treeView_Angajati.SelectedNode;
                if (selectedNode.Parent != null && selectedNode.Parent.Parent == null)
                {
                    string selectedName = selectedNode.Name;
                    Clasa_Sarcina_Manager csm= clasa_Sarcina_Managers
                        .FirstOrDefault(csmm => Path.GetFileNameWithoutExtension(csmm.GetCaleUtilizator()) == selectedName);

                    if (csm != null)
                    {
                        string folderAngajat = csm.GetCaleUtilizator();
                        clasa_Sarcina_Managers.Remove(csm);
                        selectedNode.Remove();
                        propertyGrid_Angajati.SelectedObject = null;
                       ActualizareFisierCuEmailsiParole(selectedName);
                        StergeAngajat(folderAngajat);
                    }
                    else
                    {
                        MessageBox.Show("Angajatul nu a fost găsit în lista de angajați.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nu poți șterge un departament sau un task. Selectează un angajat.", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selectează un angajat pentru a șterge.", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Adaugare_Angajat_Click(object sender, EventArgs e)
        {
           
                UtilizatorNou f = new UtilizatorNou();
                f.ShowDialog();
                treeView_Angajati.Nodes.Clear();
                Manager_Load(sender, e);
           
        }

        private void button_Adaugare_Sarcina_Click(object sender, EventArgs e)
        {
            if (treeView_Angajati.SelectedNode != null && treeView_Angajati.SelectedNode.Parent != null && treeView_Angajati.SelectedNode.Parent.Parent == null)
            {
                string folderAngajat = clasa_Sarcina_Managers.FirstOrDefault(csm => Path.GetFileNameWithoutExtension(csm.GetCaleUtilizator()) == treeView_Angajati.SelectedNode.Name)?.GetCaleUtilizator();

                if (folderAngajat != null)
                {
                    AdaugareTaskNou f = new AdaugareTaskNou();
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        string caleTask = Path.Combine(folderAngajat, $"{f.Nume}.txt");

                        using (StreamWriter writer = new StreamWriter(caleTask))
                        {
                            writer.WriteLine(f.Nume);
                            writer.WriteLine(f.Data);
                            writer.WriteLine(f.Detalii);
                        }

                        TreeNode taskNode = new TreeNode
                        {
                            Name = f.Nume,
                            Text = f.Nume,
                        };

                        treeView_Angajati.SelectedNode.Nodes.Add(taskNode);
                        treeView_Angajati.SelectedNode.Expand();
                        var csm = clasa_Sarcina_Managers.FirstOrDefault(c => Path.GetFileNameWithoutExtension(c.GetCaleUtilizator()) == treeView_Angajati.SelectedNode.Name);
                        if (csm != null)
                        {
                            csm.GetTaskuri().Add(new Task(f.Nume, Convert.ToDateTime(f.Data), f.Detalii));
                        }

                        f.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Directorul angajatului nu a fost găsit.", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Alege un angajat.", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Delogare_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void propertyGrid_Angajati_Click(object sender, EventArgs e)
        {

        }
    }
}
