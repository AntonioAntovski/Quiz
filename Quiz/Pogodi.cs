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
    public partial class Pogodi : Form
    {
        int count;
        List<Char[]> words;
        char[] guess;
        public int points;
        public Matematika matematika;
        public string korisnickoIme;
        public Pogodi(string ime)
        {
            InitializeComponent();
            korisnickoIme = ime;
            btnSledna.Enabled = false;
            count = 0;
            textBox2.Enabled = false;
            btnProveri.Enabled = false;
            this.points = 0;
            words = new List<char[]>();
            String word;
            lblPoeni.Font = new Font("Microsoft Sans Serif", 14);
            lblPoeni.Text = "0";
            this.StartPosition = FormStartPosition.CenterScreen;

            word = "слика";
            words.Add(word.ToCharArray());
            word = "јемен";
            words.Add(word.ToCharArray());
            word = "езеро";
            words.Add(word.ToCharArray());
            word = "книга";
            words.Add(word.ToCharArray());
            word = "злато";
            words.Add(word.ToCharArray());
            word = "афион";
            words.Add(word.ToCharArray());
            word = "вазна";
            words.Add(word.ToCharArray());
            word = "живот";
            words.Add(word.ToCharArray());
            word = "земја";
            words.Add(word.ToCharArray());
            word = "икона";
            words.Add(word.ToCharArray());
            word = "кифла";
            words.Add(word.ToCharArray());
            word = "локум";
            words.Add(word.ToCharArray());
            word = "љубов";
            words.Add(word.ToCharArray());
            word = "опера";
            words.Add(word.ToCharArray());
            word = "трева";
            words.Add(word.ToCharArray());
            word = "чевли";
            words.Add(word.ToCharArray());

            Random random = new Random();

            guess = new char[5];
            guess = words[random.Next(0, words.Capacity)];
        }

        private void button63_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            btnProveri.Enabled = true;
            timer1.Start();
            btnZapocni.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100) {
                btnProveri.Enabled = false;
                btnZapocni.Enabled = false;
                btnSledna.Enabled = true;
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 5) {
                errorProvider1.SetError(textBox2, "Внесете точно 5 букви");
                return;
            }
            else {
                errorProvider1.SetError(textBox2, "");
            }

            char[] word = textBox2.Text.ToLower().ToCharArray();

            if (count == 0)
            {
                w11.Text = word[0].ToString();
                w12.Text = word[1].ToString();
                w13.Text = word[2].ToString();
                w14.Text = word[3].ToString();
                w15.Text = word[4].ToString();
                w11.BackColor = getColor(word, 0);
                w12.BackColor = getColor(word, 1);
                w13.BackColor = getColor(word, 2);
                w14.BackColor = getColor(word, 3);
                w15.BackColor = getColor(word, 4);

                if (w11.BackColor.Equals(Color.LightGreen) &&
                    w12.BackColor.Equals(Color.LightGreen) &&
                    w13.BackColor.Equals(Color.LightGreen) &&
                    w14.BackColor.Equals(Color.LightGreen) &&
                    w14.BackColor.Equals(Color.LightGreen)) {

                    btnProveri.Enabled = false;
                    btnZapocni.Enabled = false;
                    timer1.Stop();
                    textBox2.Enabled = false;
                    this.points += 60;
                    lblPoeni.Text = this.points.ToString();
                    progressBar1.Value = 100;

                    correct();
                }
            }
            if (count == 1)
            {
                w21.Text = word[0].ToString();
                w22.Text = word[1].ToString();
                w23.Text = word[2].ToString();
                w24.Text = word[3].ToString();
                w25.Text = word[4].ToString();
                w21.BackColor = getColor(word, 0);
                w22.BackColor = getColor(word, 1);
                w23.BackColor = getColor(word, 2);
                w24.BackColor = getColor(word, 3);
                w25.BackColor = getColor(word, 4);

                if (w21.BackColor.Equals(Color.LightGreen) &&
                    w22.BackColor.Equals(Color.LightGreen) &&
                    w23.BackColor.Equals(Color.LightGreen) &&
                    w24.BackColor.Equals(Color.LightGreen) &&
                    w25.BackColor.Equals(Color.LightGreen)) {

                    btnProveri.Enabled = false;
                    btnZapocni.Enabled = false;
                    timer1.Stop();
                    textBox2.Enabled = false;
                    this.points += 50;
                    lblPoeni.Text = this.points.ToString();
                    progressBar1.Value = 100;

                    correct();
                }
            }
            if (count == 2)
            {
                w31.Text = word[0].ToString();
                w32.Text = word[1].ToString();
                w33.Text = word[2].ToString();
                w34.Text = word[3].ToString();
                w35.Text = word[4].ToString();
                w31.BackColor = getColor(word, 0);
                w32.BackColor = getColor(word, 1);
                w33.BackColor = getColor(word, 2);
                w34.BackColor = getColor(word, 3);
                w35.BackColor = getColor(word, 4);

                if (w31.BackColor.Equals(Color.LightGreen) &&
                    w32.BackColor.Equals(Color.LightGreen) &&
                    w33.BackColor.Equals(Color.LightGreen) &&
                    w34.BackColor.Equals(Color.LightGreen) &&
                    w35.BackColor.Equals(Color.LightGreen)) {

                    btnProveri.Enabled = false;
                    btnZapocni.Enabled = false;
                    timer1.Stop();
                    textBox2.Enabled = false;
                    this.points += 40;
                    lblPoeni.Text = this.points.ToString();
                    progressBar1.Value = 100;

                    correct();
                }
            }
            if (count == 3)
            {
                w41.Text = word[0].ToString();
                w42.Text = word[1].ToString();
                w43.Text = word[2].ToString();
                w44.Text = word[3].ToString();
                w45.Text = word[4].ToString();
                w41.BackColor = getColor(word, 0);
                w42.BackColor = getColor(word, 1);
                w43.BackColor = getColor(word, 2);
                w44.BackColor = getColor(word, 3);
                w45.BackColor = getColor(word, 4);

                if (w41.BackColor.Equals(Color.LightGreen) &&
                    w42.BackColor.Equals(Color.LightGreen) &&
                    w43.BackColor.Equals(Color.LightGreen) &&
                    w44.BackColor.Equals(Color.LightGreen) &&
                    w45.BackColor.Equals(Color.LightGreen)) {

                    btnProveri.Enabled = false;
                    btnZapocni.Enabled = false;
                    timer1.Stop();
                    textBox2.Enabled = false;
                    this.points += 30;
                    lblPoeni.Text = this.points.ToString();
                    progressBar1.Value = 100;

                    correct();
                }
            }
            if (count == 4)
            {
                w51.Text = word[0].ToString();
                w52.Text = word[1].ToString();
                w53.Text = word[2].ToString();
                w54.Text = word[3].ToString();
                w55.Text = word[4].ToString();
                w51.BackColor = getColor(word, 0);
                w52.BackColor = getColor(word, 1);
                w53.BackColor = getColor(word, 2);
                w54.BackColor = getColor(word, 3);
                w55.BackColor = getColor(word, 4);

                if (w51.BackColor.Equals(Color.LightGreen) &&
                    w52.BackColor.Equals(Color.LightGreen) &&
                    w53.BackColor.Equals(Color.LightGreen) &&
                    w54.BackColor.Equals(Color.LightGreen) &&
                    w55.BackColor.Equals(Color.LightGreen)) {

                    btnProveri.Enabled = false;
                    btnZapocni.Enabled = false;
                    timer1.Stop();
                    this.points += 20;
                    lblPoeni.Text = this.points.ToString();
                    progressBar1.Value = 100;

                    correct();
                }
            }

            if (count == 5)
            {
                w61.Text = word[0].ToString();
                w62.Text = word[1].ToString();
                w63.Text = word[2].ToString();
                w64.Text = word[3].ToString();
                w65.Text = word[4].ToString();
                w61.BackColor = getColor(word, 0);
                w62.BackColor = getColor(word, 1);
                w63.BackColor = getColor(word, 2);
                w64.BackColor = getColor(word, 3);
                w65.BackColor = getColor(word, 4);

                if (w61.BackColor.Equals(Color.LightGreen) &&
                    w62.BackColor.Equals(Color.LightGreen) &&
                    w63.BackColor.Equals(Color.LightGreen) &&
                    w64.BackColor.Equals(Color.LightGreen) &&
                    w65.BackColor.Equals(Color.LightGreen)) {

                    this.points += 10;
                    lblPoeni.Text = this.points.ToString();
                }

                textBox2.Enabled = false;
                btnProveri.Enabled = false;
                btnZapocni.Enabled = false;
                correct();
                btnProveri.Enabled = false;
                timer1.Stop();
                progressBar1.Value = 100;
            }

            textBox2.Text = "";
            count++;
            if (progressBar1.Value == 100)
            {
                btnProveri.Enabled = false;
                btnZapocni.Enabled = false;
                textBox2.Enabled = false;
                btnSledna.Enabled = true;
            }
        }

        public void correct() {
            button5.Text = guess[0].ToString();
            button4.Text = guess[1].ToString();
            button3.Text = guess[2].ToString();
            button2.Text = guess[3].ToString();
            button1.Text = guess[4].ToString();
        }

        public Color getColor(char[] word, int pos) {
            if (word[pos] == guess[pos])
            {
                return Color.LightGreen;
            }
            else if (guess.Contains(word[pos]))
            {
                return Color.IndianRed;
            }
            else
            {
                return Color.SkyBlue;
            }
        }

        private void btnSledna_Click(object sender, EventArgs e)
        {
            this.Hide();
            matematika = new Matematika(this.points,this.korisnickoIme);
            matematika.Show();
        }
    }

    class Word {
        List<Character> c;
        char[] guess;

        public Word(char[] word, char[] guess){
            this.guess = guess;

            for (int i=0; i<5; i++) {
                c.Add(new Character(word[i], getColor(word[i], guess[i], guess)));
            }
        }

        public Color getColor(char c1, char c2, char[] c) {
            if (c1 == c2)
            {
                return Color.Green;
            }
            else if (c.Contains(c1))
            {
                return Color.Red;
            }
            return Color.Black;
        }
    }

    class Character {
        //Color color;
        Char c;

        public Character(Char c, Color color) {
            //this->color = color;
            this.c = c;
        }
    }
}
