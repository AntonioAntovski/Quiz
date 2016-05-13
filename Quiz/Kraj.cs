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

namespace Quiz
{
    public partial class Kraj : Form
    {
       
        List<Player> players;
        public Kraj()
        {
            InitializeComponent();
            players = new List<Player>();
        }

        private void Kraj_Load(object sender, EventArgs e)
        {
            lbRezultati.Items.Clear();
            string name;
            string points;
            string fileName = "rezultati.txt";
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] temp = line.Split(' ');
                        name = temp[0];
                        points = temp[1];
                        int a = Int32.Parse(points);
                        players.Add(new Player() { Poeni=a, Ime = name });
                    }
              
                    players = players.OrderBy(x => x.Poeni).ToList();
                    players.Reverse();
                    for(int i = 0; i < players.Count; i++)
                    {
                        lbRezultati.Items.Add(i + 1 + ". " + players[i]);
                    }
                }
            }
            catch (Exception err)
            {
                lblErr.Text = err.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pocetna poc = new Pocetna();
            this.Hide();
            poc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kraj_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Дали навистина сакате да ја напуштите играта?", "Излез", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }

    class Player
    {
        public int Poeni { get; set; }
        public string Ime { get; set; }

        public override string ToString()
        {
            return Ime + " " + Poeni;
        }
    }
}
