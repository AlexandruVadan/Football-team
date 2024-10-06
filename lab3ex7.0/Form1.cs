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

namespace lab3ex7._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IncarcareClase();
        }

        private void IncarcareClase()
        {
            flowLayoutPanel1.Controls.Clear();
            comboBox1.Items.Clear();
            foreach (string dirPath in Directory.EnumerateDirectories(Application.StartupPath))
            {
                // adauga numele directorului, fara cale
                DirectoryInfo dirName = new DirectoryInfo(dirPath);
                comboBox1.Items.Add(dirName.Name);
            }
        }



        private void IncarcaJucatoriClasa(string clasa)
        {
            flowLayoutPanel1.Controls.Clear();
            string path = Application.StartupPath + "\\" + clasa;
            foreach (string fileName in Directory.EnumerateFiles(path, "*.txt"))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string cnp = Path.GetFileNameWithoutExtension(fileName);
                    string nume = sr.ReadLine();
                    string post = sr.ReadLine();
                    Persoana j = new Persoana(cnp, nume, post);

                    Button btn = new Button();
                    btn.Text = j.Nume;
                    btn.Width = 200;
                    btn.Tag = j;
                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            Button btn = (Button)sender;
            Persoana j = (Persoana)btn.Tag;
            listBox1.Items.Add( j.Nume);
            listBox2.Items.Add(j.Cnp);
            listBox3.Items.Add( j.Post);



        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IncarcaJucatoriClasa(comboBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }
    }
}
