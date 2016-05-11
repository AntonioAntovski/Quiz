using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class VnesiIme : Form
    {
        public Pogodi pogodi;
        public VnesiIme()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (tbIme.Text.Length == 0)
            {
                errMsg = "Мора да внесете корисничко име!";
                e.Cancel = true;
                errorProvider1.SetError(tbIme, errMsg);
            }
            else if (tbIme.Text.Contains(" "))
            {
                errMsg = "Корисничкото име не смее да содржи празно место!";
                e.Cancel = true;
                errorProvider1.SetError(tbIme, errMsg);
            }
            else
                errorProvider1.SetError(tbIme, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = tbIme.Text;
            pogodi = new Pogodi(ime);
            this.Close();
            pogodi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Pocetna w = new Pocetna();
            w.Show();
        }
    }
}
