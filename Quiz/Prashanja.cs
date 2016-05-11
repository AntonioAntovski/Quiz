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
    public partial class Prashanja : Form
    {
        Dictionary<string, Answers> questions;
        public int points;
        int count;
        List<int> randomQuest;
        public Spojuvalka spojuvalka;
        public string korisnickoIme;
        public Prashanja(int points,string ime)
        {
            InitializeComponent();
            korisnickoIme = ime;
            btnSledna.Enabled = false;
            this.points = points;
            lblPoeni.Text = points.ToString();
            timer1.Start();
            count = 1;
            randomQuest = RandomValues(11, 0, 12);

            questions = new Dictionary<string, Answers>();

            string question = "Кои две планети се соседни на Земјата?";
            Answers a = new Answers("Марс и Венера", "Сатурн и Јупитер", "Марс и Јупитер", "Уран и Плутон");
            questions.Add(question, a);

            question = "Бројот кој содржи имагинарен и реален дел се вика...";
            a = new Answers("комплексен број", "цел број", "рационален број", "прост број");
            questions.Add(question, a);

            question = "Калиграфија е убаво...";
            a = new Answers("пишување", "однесување", "зборување", "пеење");
            questions.Add(question, a);

            question = "Јоко Оно беше сопруга на...";
            a = new Answers("Џон Ленон", "Пол Меккартни", "Ринго Стар", "Џорџ Харисон");
            questions.Add(question, a);

            question = "Главниот енергетски извор на растителни клетки е...";
            a = new Answers("аденозин трифосфат", "јаглерод диоксид", "кислород", "хлорофил");
            questions.Add(question, a);

            question = "Како се нарекува сликата изработена од разнобојни камчиња на подлога од малтер?";
            a = new Answers("мозаик", "витраж", "колаж", "мурал");
            questions.Add(question, a);

            question = "Која од следниве хидроцентрали не е дел од хидросистемот Маврово?";
            a = new Answers("Шпиље", "Вруток", "Врбен", "Равен");
            questions.Add(question, a);

            question = "Колку степени според Келвиновата скала изнесува апсолутната нула?";
            a = new Answers("0", "273", "-273", "27,3");
            questions.Add(question, a);

            question = "Од каде е донесен компирот во Европа?";
            a = new Answers("Јужна Америка", "Источна Азија", "Северна Америка", "Јужна Азија");
            questions.Add(question, a);

            question = "Древниот град Вавиолон во 24-ти век п.н.е. го изградиле...";
            a = new Answers("Сумерите", "Асирците", "Феничаните", "Египќаните");
            questions.Add(question, a);

            question = "Во која држава претседателот се избира секоја година?";
            a = new Answers("Швајцарија", "Словачка", "Финска", "Португалија");
            questions.Add(question, a);

            question = "Кој од следниве актери не е дете на добитник на Оскар?";
            a = new Answers("Чарли Шин", "Кејт Хадсон", "Анџелина Џоли", "Џејн Фонда");
            questions.Add(question, a);


            List<string> quest = new List<string>(questions.Keys);
            lblPrashanje.Font = new Font("Microsoft Sans Serif", 12);
            lblPrashanje.Text = quest[randomQuest[count]];
            
            Answers tmp = questions[lblPrashanje.Text];
            List<string> ans = tmp.getAnswers();
            List<int> randoms = RandomValues(4, 0, 4);

            odg1.Text = ans[randoms[0]];
            odg2.Text = ans[randoms[1]];
            odg3.Text = ans[randoms[2]];
            odg4.Text = ans[randoms[3]];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }

        private void Check() {
            if (count == 10)
            {
                odg1.Enabled = false;
                odg2.Enabled = false;
                odg3.Enabled = false;
                odg4.Enabled = false;
                btnSledna.Enabled = true;
                progressBar1.Value = 100;
                timer1.Stop();
            }
            else {
                count++;
                List<string> question = new List<string>(questions.Keys);
                lblPrashanje.Text = question[randomQuest[count]];
                
                List<String> value = questions[lblPrashanje.Text].getAnswers();
                List<int> randoms = RandomValues(4, 0, 4);

                odg1.Text = value[randoms[0]];
                odg2.Text = value[randoms[1]];
                odg3.Text = value[randoms[2]];
                odg4.Text = value[randoms[3]];
                if (progressBar1.Value == 100)
                    btnSledna.Enabled = true;
            }
        }

        private List<int> RandomValues(int num, int min, int max) {
            List<int> randomNumbers = new List<int>();
            Random random = new Random();

            for (int i = 0; i < num; i++)
            {
                int number;

                do number = random.Next(min, max);
                while (randomNumbers.Contains(number));

                randomNumbers.Add(number);
            }

            return randomNumbers;
        }

        private void odg1_Click(object sender, EventArgs e)
        {
            List<string> value = questions[lblPrashanje.Text].getAnswers();
            String str = questions[lblPrashanje.Text].getRightAnswer();

            if (odg1.Text.Equals(str)) {
                points += 10;
                lblPoeni.Text = (short.Parse(lblPoeni.Text) + 10).ToString();
            }
            else {
                points -= 5;
                lblPoeni.Text = (short.Parse(lblPoeni.Text) - 5).ToString();
            }

            Check();
        }

        private void odg2_Click(object sender, EventArgs e)
        {
            List<string> value = questions[lblPrashanje.Text].getAnswers();
            String str = questions[lblPrashanje.Text].getRightAnswer();

            if (odg2.Text.Equals(str))
            {
                points += 10;
                lblPoeni.Text = (short.Parse(lblPoeni.Text) + 10).ToString();
            }
            else {
                points -= 5;
                lblPoeni.Text = (short.Parse(lblPoeni.Text) - 5).ToString();
            }

            Check();
        }

        private void odg3_Click(object sender, EventArgs e)
        {
            List<string> value = questions[lblPrashanje.Text].getAnswers();
            String str = questions[lblPrashanje.Text].getRightAnswer();

            if (odg3.Text.Equals(str))
            {
                points += 10;
                lblPoeni.Text = (short.Parse(lblPoeni.Text) + 10).ToString();
            }
            else {
                points -= 5;
                lblPoeni.Text = (short.Parse(lblPoeni.Text) - 5).ToString();
            }

            Check();
        }

        private void odg4_Click(object sender, EventArgs e)
        {
            List<string> value = questions[lblPrashanje.Text].getAnswers();
            String str = questions[lblPrashanje.Text].getRightAnswer();

            if (odg4.Text.Equals(str))
            {
                points += 10;
                lblPoeni.Text = (short.Parse(lblPoeni.Text) + 10).ToString();
            }
            else {
                points -= 5;
                lblPoeni.Text = (short.Parse(lblPoeni.Text) - 5).ToString();
            }

            Check();
        }

        private void btnSledna_Click(object sender, EventArgs e)
        {
            this.Hide();
            spojuvalka = new Spojuvalka(this.points, this.korisnickoIme);
            spojuvalka.Show();
        }
    }

    class Question {
        string question;

        public Question(string str) {
            question = str;
        }
    }

    class Answers {
        private List<string> answers;
        private string right;

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();


        public Answers(string fi, string s, string t, string f) {
            answers = new List<string>()
            {
                fi, s, t, f
            };

            right = fi;
        }

        public string getRightAnswer() {
            return right;
        }

        public List<string> getAnswers() {
            return answers;
        }
    }
}
