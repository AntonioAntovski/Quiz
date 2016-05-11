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
    public partial class Matematika : Form
    {
        public int points;
        public Prashanja prashanja;
        public string korisnickoIme;
        public Matematika(int points, string ime)
        {
            InitializeComponent();
            korisnickoIme = ime;
            this.points = points;
            lblPoeni.Text = points.ToString();
            btnIzbrisi.Enabled = false;
            btnSledna.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnIzbrisi.Enabled = true;
            Random rd = new Random();
            txtPrv.Text = rd.Next(1, 10).ToString();
            txtPrv.Enabled = true;
            txtVtor.Text = rd.Next(1, 10).ToString();
            txtVtor.Enabled = true;
            txtTret.Text = rd.Next(1, 10).ToString();
            txtTret.Enabled = true;
            txtCetvrti.Text = rd.Next(1, 10).ToString();
            txtCetvrti.Enabled = true;
            int flag = rd.Next(0, 3);
            if (flag == 0)
                txtPetti.Text = "10";
            else if (flag == 1)
                txtPetti.Text = "15";
            else
                txtPetti.Text = "20";
            txtPetti.Enabled = true;
            flag = rd.Next(0, 4);
            if (flag == 0)
                txtSesti.Text = "25";
            else if (flag == 1)
                txtSesti.Text = "50";
            else if (flag == 2)
                txtSesti.Text = "75";
            else
                txtSesti.Text = "100";
            txtSesti.Enabled = true;
            txtBaranBroj.Text = rd.Next(1, 1000).ToString();
            btnStart.Enabled = false;
        }

        private void txtPrv_Click(object sender, EventArgs e)
        {
            txtResenie.Text += txtPrv.Text;
            txtPrv.Enabled = false;
        }

        private void txtVtor_Click(object sender, EventArgs e)
        {
            txtResenie.Text += txtVtor.Text;
            txtVtor.Enabled = false;
        }

        private void txtTret_Click(object sender, EventArgs e)
        {
            txtResenie.Text += txtTret.Text;
            txtTret.Enabled = false;
        }

        private void txtCetvrti_Click(object sender, EventArgs e)
        {
            txtResenie.Text += txtCetvrti.Text;
            txtCetvrti.Enabled = false;
        }

        private void txtPetti_Click(object sender, EventArgs e)
        {
            txtResenie.Text += txtPetti.Text;
            txtPetti.Enabled = false;
        }

        private void txtSesti_Click(object sender, EventArgs e)
        {
            txtResenie.Text += txtSesti.Text;
            txtSesti.Enabled = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtResenie.Text.Length != 0 && txtResenie.Text[txtResenie.Text.Length - 1] != '+' && txtResenie.Text[txtResenie.Text.Length - 1] != '-'
                && txtResenie.Text[txtResenie.Text.Length - 1] != '*' && txtResenie.Text[txtResenie.Text.Length - 1] != '/'
                && txtResenie.Text[txtResenie.Text.Length - 1] != '(')
                txtResenie.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtResenie.Text.Length != 0 && txtResenie.Text[txtResenie.Text.Length - 1] != '+' && txtResenie.Text[txtResenie.Text.Length - 1] != '-'
                && txtResenie.Text[txtResenie.Text.Length - 1] != '*' && txtResenie.Text[txtResenie.Text.Length - 1] != '/'
                && txtResenie.Text[txtResenie.Text.Length - 1] != '(')
                txtResenie.Text += "-";
        }

        private void btnMnozenje_Click(object sender, EventArgs e)
        {
            if (txtResenie.Text.Length != 0 && txtResenie.Text[txtResenie.Text.Length - 1] != '+' && txtResenie.Text[txtResenie.Text.Length - 1] != '-'
                && txtResenie.Text[txtResenie.Text.Length - 1] != '*' && txtResenie.Text[txtResenie.Text.Length - 1] != '/'
                && txtResenie.Text[txtResenie.Text.Length - 1] != '(')
                txtResenie.Text += "*";
        }

        private void btnDelenje_Click(object sender, EventArgs e)
        {
            if(txtResenie.Text.Length != 0 && txtResenie.Text[txtResenie.Text.Length - 1] != '+' && txtResenie.Text[txtResenie.Text.Length - 1] != '-'
                && txtResenie.Text[txtResenie.Text.Length - 1] != '*' && txtResenie.Text[txtResenie.Text.Length - 1] != '/'
                && txtResenie.Text[txtResenie.Text.Length - 1] != '(')
                txtResenie.Text += "/";
        }

        private void btnOtvoriZagrada_Click(object sender, EventArgs e)
        {
            if (txtResenie.Text.Length == 0 || txtResenie.Text[txtResenie.Text.Length - 1] != ')')
                txtResenie.Text += "(";
        }

        private void btnZatvoriZagrada_Click(object sender, EventArgs e)
        {
            if (txtResenie.Text.Length != 0 && txtResenie.Text[txtResenie.Text.Length - 1] != '+' && txtResenie.Text[txtResenie.Text.Length - 1] != '-'
                && txtResenie.Text[txtResenie.Text.Length - 1] != '*' && txtResenie.Text[txtResenie.Text.Length - 1] != '/'
                && txtResenie.Text[txtResenie.Text.Length - 1] != '(')
                txtResenie.Text += ")";
        }

        private void btnKraj_Click(object sender, EventArgs e)
        {
            MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
            sc.Language = "VBScript";
            string expression = txtResenie.Text;
            object result = null;
            try {
                result = sc.Eval(expression);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                return;
            }
            if (result == null)
                return;
            txtKonecen.Text = result.ToString();
            DisableAll();
            int rez = Convert.ToInt32(txtKonecen.Text);
            int baran = Convert.ToInt32(txtBaranBroj.Text);
            if (rez == baran)
                this.points += 10;
            else if (Math.Abs(rez - baran) <= 5)
                this.points += 5;
            else
                this.points += 0;

          
            lblPoeni.Text = this.points.ToString();
            progressBar1.Value = 100;
            btnKraj.Enabled = false;
            btnSledna.Enabled = true;
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            txtResenie.Text = "";
            txtPrv.Enabled = true;
            txtVtor.Enabled = true;
            txtTret.Enabled = true;
            txtCetvrti.Enabled = true;
            txtPetti.Enabled = true;
            txtSesti.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value == 100 && lblPoeni.Text == "")
            {
                DisableAll();
                lblPoeni.Text = "0";
                btnSledna.Enabled = true;
            }
            if (progressBar1.Value == 100)
                btnSledna.Enabled = true;
        }

        private void DisableAll()
        {
            txtPrv.Enabled = false;
            txtVtor.Enabled = false;
            txtTret.Enabled = false;
            txtCetvrti.Enabled = false;
            txtPetti.Enabled = false;
            txtSesti.Enabled = false;
            btnIzbrisi.Enabled = false;
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
            btnMnozenje.Enabled = false;
            btnDelenje.Enabled = false;
            btnOtvoriZagrada.Enabled = false;
            btnZatvoriZagrada.Enabled = false;
        }

        private void btnSledna_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            prashanja = new Prashanja(this.points, this.korisnickoIme);
            prashanja.Show();
        }
    }
}
