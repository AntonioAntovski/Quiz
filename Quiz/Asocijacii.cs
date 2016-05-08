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
    public partial class Asocijacii : Form
    {
        public Asocijacija konecna;
        public int points;
        private int obidi;
        public Kraj kraj;

        public Asocijacii(int points)
        {
            InitializeComponent();
            this.points = points;
            txtPoeni.Text = points.ToString();
            string[] a11 = { "СПОРТСКИ", "БРОЈ", "МАИЦА", "РЕПРЕЗЕНТАЦИЈА", "ДРЕС" };
            string[] b11 = { "ИТАЛИЈА", "ТАЈНАТА ВЕЧЕРА", "МОНА ЛИЗА", "РЕНЕСАНСА", "ДА ВИНЧИ" };
            string[] v11 = { "УЛИЦА", "БРОЈ", "IP", "URL", "АДРЕСА" };
            string[] g11 = { "0", "ЗАПИС", "1", "СИСТЕМ", "БИНАРЕН" };
            Asocijacija a1 = new Asocijacija(a11, b11, v11, g11, "КОД");
            string[] a21 = { "ГРАМОФОН", "БОР", "КОНЕЦ", "КРАВАТА", "ИГЛА" };
            string[] b21 = { "ПТИЦА", "КАШЛАЊЕ", "ИНФЛУЕНЦА", "СВИЊА", "ГРИП" };
            string[] v21 = { "ВОСПАЛЕНИЕ", "HIV", "КОМПЈУТЕР", "ИНФЕКЦИЈА", "ВИРУС" };
            string[] g21 = { "ГОЛЕМИ", "VARIOLA VERA", "МАЛИ", "ОВЧИ", "СИПАНИЦИ" };
            Asocijacija a2 = new Asocijacija(a21, b21, v21, g21, "ВАКЦИНА");
            string[] a31 = { "ЦЕЛ", "НЕГАТИВЕН", "ПОЗИТИВЕН", "ИМАГИНАРЕН", "БРОЈ" };
            string[] b31 = { "ЗЕМЈА", "ГЛОБУС", "ВОЈНА", "БЕЛ", "СВЕТ" };
            string[] v31 = { "МАГИЈА", "НЕВИДЕНО", "... ОД ДЕТЕ", "ПРИРОДА", "ЧУДО" };
            string[] g31 = { "ТОПЧИЊА", "СРЕЌА", "СЕДМИЦА", "ДОБИВКА", "ЛОТО" };
            Asocijacija a3 = new Asocijacija(a31, b31, v31, g31, "СЕДУМ");
            string[] a41 = { "ЉУБОВ", "ПИСТА", "ОБЛЕКА", "КРЕАЦИЈА", "МОДА" };
            string[] b41 = { "СОНЦЕ", "ДЕН", "СИЈАЛИЦА", "СВЕЌА", "СВЕТЛИНА" };
            string[] v41 = { "МАРШ", "ПОБЕДА", "ОПЕРАЦИЈА", "ДОМИНАЦИЈА", "ТРИУМФ" };
            string[] g41 = { "ВРАТА", "ДВОР", "ОГРАДА", "КАПИЈА", "ПОРТА" };
            Asocijacija a4 = new Asocijacija(a41, b41, v41, g41, "ПАРИЗ");
            string[] a51 = { "РЕКА", "КОСКА", "АЈКУЛА", "ПАСТРМКА", "РИБА" };
            string[] b51 = { "РЕКЕТ", "ТОПЧЕ", "СПОРТ", "СЕТ", "ТЕНИС" };
            string[] v51 = { "MICASA", "БЛОК", "СЕРВИС", "ПЛАЖА", "ОДБОЈКА" };
            string[] g51 = { "ИГРА", "ИНТЕРНЕТ", "ГЛУШЕЦ", "ВИРУС", "КОМПЈУТЕР" };
            Asocijacija a5 = new Asocijacija(a51, b51, v51, g51, "МРЕЖА");
            this.obidi = 0;
            Random rd = new Random();
            int n = rd.Next(1, 6);
            if (n == 1)
                konecna = a1;
            else if (n == 2)
                konecna = a2;
            else if (n == 3)
                konecna = a3;
            else if (n == 4)
                konecna = a4;
            else
                konecna = a5;
            timer1.Start();
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            btnA1.Text = konecna.A[0];
            btnA1.Enabled = false;
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            btnA2.Text = konecna.A[1];
            btnA2.Enabled = false;
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            btnA3.Text = konecna.A[2];
            btnA3.Enabled = false;
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            btnA4.Text = konecna.A[3];
            btnA4.Enabled = false;
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            btnB1.Text = konecna.B[0];
            btnB1.Enabled = false;
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            btnB2.Text = konecna.B[1];
            btnB2.Enabled = false;
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            btnB3.Text = konecna.B[2];
            btnB3.Enabled = false;
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            btnB4.Text = konecna.B[3];
            btnB4.Enabled = false;
        }

        private void btnV1_Click(object sender, EventArgs e)
        {
            btnV1.Text = konecna.V[0];
            btnV1.Enabled = false;
        }

        private void btnV2_Click(object sender, EventArgs e)
        {
            btnV2.Text = konecna.V[1];
            btnV2.Enabled = false;
        }

        private void btnV3_Click(object sender, EventArgs e)
        {
            btnV3.Text = konecna.V[2];
            btnV3.Enabled = false;
        }

        private void btnV4_Click(object sender, EventArgs e)
        {
            btnV4.Text = konecna.V[3];
            btnV4.Enabled = false;
        }

        private void btnG1_Click(object sender, EventArgs e)
        {
            btnG1.Text = konecna.G[0];
            btnG1.Enabled = false;
        }

        private void btnG2_Click(object sender, EventArgs e)
        {
            btnG2.Text = konecna.G[1];
            btnG2.Enabled = false;
        }

        private void btnG3_Click(object sender, EventArgs e)
        {
            btnG3.Text = konecna.G[2];
            btnG3.Enabled = false;
        }

        private void btnG4_Click(object sender, EventArgs e)
        {
            btnG4.Text = konecna.G[3];
            btnG4.Enabled = false;
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtA.Text.ToUpper().Equals(konecna.A[4]))
                {
                    btnA1.BackColor = Color.Green;
                    btnA1.Text = konecna.A[0];
                    btnA2.BackColor = Color.Green;
                    btnA2.Text = konecna.A[1];
                    btnA3.BackColor = Color.Green;
                    btnA3.Text = konecna.A[2];
                    btnA4.BackColor = Color.Green;
                    btnA4.Text = konecna.A[3];
                    A.BackColor = Color.Green;
                    A.Enabled = false;
                    A.Visible = true;
                    A.Text = konecna.A[4];
                    points += 5;
                    txtPoeni.Text = points.ToString();
                    obidi++;
                }
                else
                    txtA.Text = "";
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtB.Text.ToUpper().Equals(konecna.B[4]))
                {
                    btnB1.BackColor = Color.Green;
                    btnB1.Text = konecna.B[0];
                    btnB2.BackColor = Color.Green;
                    btnB2.Text = konecna.B[1];
                    btnB3.BackColor = Color.Green;
                    btnB3.Text = konecna.B[2];
                    btnB4.BackColor = Color.Green;
                    btnB4.Text = konecna.B[3];
                    B.BackColor = Color.Green;
                    B.Enabled = false;
                    B.Visible = true;
                    B.Text = konecna.B[4];
                    points += 5;
                    txtPoeni.Text = points.ToString();
                    obidi++;
                }
                else
                    txtB.Text = "";
            }
        }

        private void txtV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtV.Text.ToUpper().Equals(konecna.V[4]))
                {
                    btnV1.BackColor = Color.Green;
                    btnV1.Text = konecna.V[0];
                    btnV2.BackColor = Color.Green;
                    btnV2.Text = konecna.V[1];
                    btnV3.BackColor = Color.Green;
                    btnV3.Text = konecna.V[2];
                    btnV4.BackColor = Color.Green;
                    btnV4.Text = konecna.V[3];
                    V.BackColor = Color.Green;
                    V.Enabled = false;
                    V.Visible = true;
                    V.Text = konecna.V[4];
                    points += 5;
                    txtPoeni.Text = points.ToString();
                    obidi++;
                }
                else
                    txtV.Text = "";
            }
        }

        private void txtG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtG.Text.ToUpper().Equals(konecna.G[4]))
                {
                    btnG1.BackColor = Color.Green;
                    btnG1.Text = konecna.G[0];
                    btnG2.BackColor = Color.Green;
                    btnG2.Text = konecna.G[1];
                    btnG3.BackColor = Color.Green;
                    btnG3.Text = konecna.G[2];
                    btnG4.BackColor = Color.Green;
                    btnG4.Text = konecna.G[3];
                    G.BackColor = Color.Green;
                    G.Enabled = false;
                    G.Visible = true;
                    G.Text = konecna.G[4];
                    points += 5;
                    txtPoeni.Text = points.ToString();
                    obidi++;
                }
                else
                    txtG.Text = "";
            }
        }

        private void txtKonecno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (txtKonecno.Text.ToUpper().Equals(konecna.Konecno))
                {
                    Konecno.BackColor = Color.Green;
                    Konecno.Enabled = false;
                    Konecno.Visible = true;
                    Konecno.Text = konecna.Konecno;

                    btnA1.BackColor = Color.Green;
                    btnA1.Text = konecna.A[0];
                    btnA2.BackColor = Color.Green;
                    btnA2.Text = konecna.A[1];
                    btnA3.BackColor = Color.Green;
                    btnA3.Text = konecna.A[2];
                    btnA4.BackColor = Color.Green;
                    btnA4.Text = konecna.A[3];
                    A.BackColor = Color.Green;
                    A.Enabled = false;
                    A.Visible = true;
                    A.Text = konecna.A[4];

                    btnB1.BackColor = Color.Green;
                    btnB1.Text = konecna.B[0];
                    btnB2.BackColor = Color.Green;
                    btnB2.Text = konecna.B[1];
                    btnB3.BackColor = Color.Green;
                    btnB3.Text = konecna.B[2];
                    btnB4.BackColor = Color.Green;
                    btnB4.Text = konecna.B[3];
                    B.BackColor = Color.Green;
                    B.Enabled = false;
                    B.Visible = true;
                    B.Text = konecna.B[4];

                    btnV1.BackColor = Color.Green;
                    btnV1.Text = konecna.V[0];
                    btnV2.BackColor = Color.Green;
                    btnV2.Text = konecna.V[1];
                    btnV3.BackColor = Color.Green;
                    btnV3.Text = konecna.V[2];
                    btnV4.BackColor = Color.Green;
                    btnV4.Text = konecna.V[3];
                    V.BackColor = Color.Green;
                    V.Enabled = false;
                    V.Visible = true;
                    V.Text = konecna.V[4];

                    btnG1.BackColor = Color.Green;
                    btnG1.Text = konecna.G[0];
                    btnG2.BackColor = Color.Green;
                    btnG2.Text = konecna.G[1];
                    btnG3.BackColor = Color.Green;
                    btnG3.Text = konecna.G[2];
                    btnG4.BackColor = Color.Green;
                    btnG4.Text = konecna.G[3];
                    G.BackColor = Color.Green;
                    G.Enabled = false;
                    G.Visible = true;
                    G.Text = konecna.G[4];
                    if (obidi == 0)
                        points += 30;
                    else if (obidi == 1)
                        points += 25;
                    else if (obidi == 2)
                        points += 20;
                    else if (obidi == 3)
                        points += 15;
                    else
                        points += 10;
                    txtPoeni.Text = points.ToString();
                    progressBar1.Value = 100;
                }
                else
                    txtKonecno.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value == 100 && txtPoeni.Text == "")
            {
                txtPoeni.Text = "0";
                this.points = 0;
            }
        }

        private void btnKraj_Click(object sender, EventArgs e)
        {
            this.Hide();
            kraj = new Kraj(this.points);
            kraj.Show();
        }
    }
}