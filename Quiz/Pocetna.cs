using System;
using System.Windows.Forms;

namespace Quiz
{ 
    public partial class Pocetna : Form
    {
        public VnesiIme vi;
        public Pocetna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            vi = new VnesiIme();
            vi.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pocetna_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
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
}
