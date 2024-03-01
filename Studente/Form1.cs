using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studente
{
    public partial class Form1 : Form
    {
        List<Persona> listP = new List<Persona>();
        List<Studente> listS = new List<Studente>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Persona p1 = new Persona(textBox2.Text, textBox1.Text, Convert.ToDateTime(textBox3.Text)); // Crea un oggetto di tipo persona
            if (p1.Controllo(p1, listP))
            {
                listBox1.Items.Add("Persona già presente");
            }
            else
            {
                listP.Add(p1);
                listBox1.Items.Add(p1.ToString()); // Stampo a video nella listBox
            }
        }

        private void studenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            Studente s1 = new Studente(Convert.ToInt32(textBox5.Text), Convert.ToDouble(textBox4.Text), textBox2.Text, textBox1.Text, Convert.ToDateTime(textBox3.Text));
            if (s1.Controllo(s1, listS))
            {
                listBox1.Items.Add("Studente già presente");
            }
            else
            {
                listS.Add(s1);
                listBox1.Items.Add(s1.ToString()); // Stampo a video nella listBox
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
