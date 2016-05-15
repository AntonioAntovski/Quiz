using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Spojuvalka : Form
    {
        private  List<Poim> kraj1;
        private  List<Poim> kraj2;
        public int points;
        public Asocijacii asocijacii;
        public string korisnickoIme;
        public Spojuvalka(int points, string ime)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            korisnickoIme = ime;
            this.points = points;
            lblPoeni.Text = points.ToString();
            Random rand = new Random();
            int komb = rand.Next(1, 6);
            List<Poim> p1;
            List<Poim> p2;
            populateLists(komb, out p1, out p2);
            btnNextGame.Enabled = false;
             kraj1 = new List<Poim>();
             kraj2 = new List<Poim>();

            for(int i = 0; i < p1.Count; i++)
            {
                kraj1.Add(p1[i]);
                kraj2.Add(p2[i]);
            }
        }

        private void populateLists(int rr, out List<Poim> p1, out List<Poim> p2)
        {
            p1 = new List<Poim>();
            p2 = new List<Poim>();
            if (rr == 1)
            {
                txtBoxOpis.Text = "Поврзи ги државите во кои се наоѓаат соодветните градови.";
                p1.Add(new Poim() { Value = "Мексико", Ind = 2 });
                p1.Add(new Poim() { Value = "Бразил", Ind = 4 });
                p1.Add(new Poim() { Value = "Германија", Ind = 1 });
                p1.Add(new Poim() { Value = "Јапонија", Ind = 3 });
                p1.Add(new Poim() { Value = "Норвешка", Ind = 5 });
                p1.Add(new Poim() { Value = "Конго", Ind = 7 });
                p1.Add(new Poim() { Value = "Нов Зеланд", Ind = 9 });
                p1.Add(new Poim() { Value = "Канада", Ind = 6 });
                p1.Add(new Poim() { Value = "Колумбија", Ind = 10 });
                p1.Add(new Poim() { Value = "Монголија", Ind = 8 });

                p1 = p1.OrderBy(emp => Guid.NewGuid()).ToList();
                lstLevo.Items.AddRange(p1.ToArray());
                lstLevo.DisplayMember = "Value";
                lstLevo.ValueMember = "Ind";
                p2.Add(new Poim() { Value = "Берлин", Ind = 1 });
                p2.Add(new Poim() { Value = "Тихуана", Ind = 2 });
                p2.Add(new Poim() { Value = "Токио", Ind = 3 });
                p2.Add(new Poim() { Value = "Рио де Жанеиро", Ind = 4 });
                p2.Add(new Poim() { Value = "Квебек", Ind = 6 });
                p2.Add(new Poim() { Value = "Улан Батор", Ind = 8 });
                p2.Add(new Poim() { Value = "Осло", Ind = 5 });
                p2.Add(new Poim() { Value = "Матади", Ind = 7 });
                p2.Add(new Poim() { Value = "Меделин", Ind = 10 });
                p2.Add(new Poim() { Value = "Велингтон", Ind = 9 });

               
                p2 = p2.OrderBy(emp => Guid.NewGuid()).ToList();
                lstDesno.Items.AddRange(p2.ToArray());
                lstDesno.DisplayMember = "Value";
                lstDesno.ValueMember = "Ind";
            }
            else if (rr == 2)
            {
                txtBoxOpis.Text = "Поврзи ги спортистите со соодветниот спорт.";

                p1.Add(new Poim() { Value = "Линзи Вон", Ind = 9 });
                p1.Add(new Poim() { Value = "Лионел Меси", Ind = 3 });
                p1.Add(new Poim() { Value = "Стефан Кари", Ind = 4 });
                p1.Add(new Poim() { Value = "Кортни Томсон", Ind = 10 });
                p1.Add(new Poim() { Value = "Новак Ѓоковиќ", Ind = 2 });
                p1.Add(new Poim() { Value = "Миша Тејт", Ind = 8 });
                p1.Add(new Poim() { Value = "Алекс Овечкин", Ind = 1 });
                p1.Add(new Poim() { Value = "Талита Антунес", Ind = 7 });
                p1.Add(new Poim() { Value = "Том Брејди", Ind = 5 });
                p1.Add(new Poim() { Value = "Пејџ Спиранак", Ind = 6 });
                p1 = p1.OrderBy(emp => Guid.NewGuid()).ToList();
                lstLevo.Items.AddRange(p1.ToArray());
                lstLevo.DisplayMember = "Value";
                lstLevo.ValueMember = "Ind";

                p2.Add(new Poim() { Value = "Одбојка", Ind = 10 });
                p2.Add(new Poim() { Value = "Голф", Ind = 6 });
                p2.Add(new Poim() { Value = "Тенис", Ind = 2 });
                p2.Add(new Poim() { Value = "Кошарка", Ind = 4 });
                p2.Add(new Poim() { Value = "ММА", Ind = 8 });
                p2.Add(new Poim() { Value = "Фудбал", Ind = 3 });
                p2.Add(new Poim() { Value = "Одбојка на плажа", Ind = 7 });
                p2.Add(new Poim() { Value = "Хокеј на мраз", Ind = 1 });
                p2.Add(new Poim() { Value = "Американски фудбал", Ind = 5 });
                p2.Add(new Poim() { Value = "Скијање", Ind = 9 });
                

                p2 = p2.OrderBy(emp => Guid.NewGuid()).ToList();
                lstDesno.Items.AddRange(p2.ToArray());
                lstDesno.DisplayMember = "Value";
                lstDesno.ValueMember = "Ind";
            }
            else if (rr == 3)
            {
                txtBoxOpis.Text = "Поврзи ги изведувачите со нивните песни";
                p1.Add(new Poim() { Value = "Sia", Ind = 4 });
                p1.Add(new Poim() { Value = "Beyonce", Ind = 2 });
                p1.Add(new Poim() { Value = "Eminem", Ind = 3 });
                p1.Add(new Poim() { Value = "Ed Sheeran", Ind = 1 });
                p1.Add(new Poim() { Value = "Sam Smith", Ind = 8 });
                p1.Add(new Poim() { Value = "John Legend", Ind = 5 });
                p1.Add(new Poim() { Value = "Ellie Goulding", Ind = 10 });
                p1.Add(new Poim() { Value = "Rihanna", Ind = 6 });
                p1.Add(new Poim() { Value = "Bruno Mars", Ind = 9 });
                p1.Add(new Poim() { Value = "Taylor Swift", Ind = 7 });

                p1 = p1.OrderBy(emp => Guid.NewGuid()).ToList();
                lstLevo.Items.AddRange(p1.ToArray());
                lstLevo.DisplayMember = "Value";
                lstLevo.ValueMember = "Ind";

                p2.Add(new Poim() { Value = "Till I collapse", Ind = 3 });
                p2.Add(new Poim() { Value = "Halo", Ind= 2 });
                p2.Add(new Poim() { Value = "Cheap thrills", Ind = 4 });
                p2.Add(new Poim() { Value = "Army", Ind = 10 });
                p2.Add(new Poim() { Value = "Gorilla", Ind = 9 });
                p2.Add(new Poim() { Value = "Work", Ind = 6 });
                p2.Add(new Poim() { Value = "Photograph", Ind = 1 });
                p2.Add(new Poim() { Value = "Stay with me", Ind = 8 });
                p2.Add(new Poim() { Value = "Shake it off", Ind = 7 });
                p2.Add(new Poim() { Value = "All of me", Ind = 5 });

                p2 = p2.OrderBy(emp => Guid.NewGuid()).ToList();
                lstDesno.Items.AddRange(p2.ToArray());
                lstDesno.DisplayMember = "Value";
                lstDesno.ValueMember = "Ind";
            }
            else if(rr == 4)
            {
                txtBoxOpis.Text = "Поврзи ги авторите со нивните дела";
                p1.Add(new Poim() { Value = "Крејг Шо Гарднер", Ind = 1 });
                p1.Add(new Poim() { Value = "Џек Лондон", Ind = 2 });
                p1.Add(new Poim() { Value = "Џонатан Свифт", Ind = 3 });
                p1.Add(new Poim() { Value = "Григор Прличев", Ind = 4 });
                p1.Add(new Poim() { Value = "Ф. М. Достоевски", Ind = 5});
                p1.Add(new Poim() { Value = "Вилијам Шекспир", Ind = 6 });
                p1.Add(new Poim() { Value = "Кочо Рацин", Ind = 7 });
                p1.Add(new Poim() { Value = "Ден Браун", Ind = 8 });
                p1.Add(new Poim() { Value = "Енди Вир", Ind = 9 });
                p1.Add(new Poim() { Value = "Џејмс Патерсон", Ind = 10 });

                p1 = p1.OrderBy(emp => Guid.NewGuid()).ToList();
                lstLevo.Items.AddRange(p1.ToArray());
                lstLevo.DisplayMember = "Value";
                lstLevo.ValueMember = "Ind";

                p2.Add(new Poim() { Value = "\"Бетмен\"", Ind = 1 });
                p2.Add(new Poim() { Value = "\"Бела канџа\"", Ind = 2 });
                p2.Add(new Poim() { Value = "\"Битка на книгите\"", Ind = 3 });
                p2.Add(new Poim() { Value = "\"Сердарот\"", Ind = 4 });
                p2.Add(new Poim() { Value = "\"Злосторство и казна\"", Ind = 5 });
                p2.Add(new Poim() { Value = "\"Хамлет\"", Ind = 6 });
                p2.Add(new Poim() { Value = "\"Бели мугри\"", Ind = 7 });
                p2.Add(new Poim() { Value = "\"Ангели и демони\"", Ind = 8 });
                p2.Add(new Poim() { Value = "\"Марсовецот\"", Ind = 9 });
                p2.Add(new Poim() { Value = "\"Двојна измама\"", Ind = 10 });

                p2 = p2.OrderBy(emp => Guid.NewGuid()).ToList();
                lstDesno.Items.AddRange(p2.ToArray());
                lstDesno.DisplayMember = "Value";
                lstDesno.ValueMember = "Ind";
            }
            else if(rr == 5)
            {
                txtBoxOpis.Text = "Поврзи ги пронаоѓачите со нивните изуми";
                p1.Add(new Poim() { Value = "Елизабет Маги", Ind = 1 });
                p1.Add(new Poim() { Value = "Томас Едисон", Ind = 2 });
                p1.Add(new Poim() { Value = "Чарлс Бебиџ", Ind = 3 });
                p1.Add(new Poim() { Value = "Џејмс Ват", Ind = 4 });
                p1.Add(new Poim() { Value = "Александар Бел", Ind = 5 });
                p1.Add(new Poim() { Value = "Галилео Галилеј", Ind = 6 });
                p1.Add(new Poim() { Value = "Роберт Опенхајмер", Ind = 7 });
                p1.Add(new Poim() { Value = "Тим Бернерс-Ли", Ind = 8 });
                p1.Add(new Poim() { Value = "Даисуке Иноуе", Ind = 9 });
                p1.Add(new Poim() { Value = "Нилс Болин", Ind = 10 });

                p1 = p1.OrderBy(emp => Guid.NewGuid()).ToList();
                lstLevo.Items.AddRange(p1.ToArray());
                lstLevo.DisplayMember = "Value";
                lstLevo.ValueMember = "Ind";

                p2.Add(new Poim() { Value = "Монопол", Ind = 1 });
                p2.Add(new Poim() { Value = "Електрична ламба", Ind = 2 });
                p2.Add(new Poim() { Value = "Механички компјутер", Ind = 3 });
                p2.Add(new Poim() { Value = "Парна машина", Ind = 4 });
                p2.Add(new Poim() { Value = "Телефон", Ind = 5 });
                p2.Add(new Poim() { Value = "Телескоп", Ind = 6 });
                p2.Add(new Poim() { Value = "Атомска бомба", Ind = 7 });
                p2.Add(new Poim() { Value = "World Wide Web", Ind = 8 });
                p2.Add(new Poim() { Value = "Караоке машина", Ind = 9 });
                p2.Add(new Poim() { Value = "Сигурносен појас", Ind = 10 });

                p2 = p2.OrderBy(emp => Guid.NewGuid()).ToList();
                lstDesno.Items.AddRange(p2.ToArray());
                lstDesno.DisplayMember = "Value";
                lstDesno.ValueMember = "Ind";
            }
        }

        private void lstLevo_SelectedIndexChanged(object sender, EventArgs e)
        {
                check();    
        }

        private void lstDesno_SelectedIndexChanged(object sender, EventArgs e)
        {
                 check();
        }
        private void fillLeft()
        {
            List<Poim> tempList = new List<Poim>();
            for (int i = 0; i < lstLevo.Items.Count; i++)
            {
                tempList.Add(lstLevo.Items[i] as Poim);
            }
            Poim qwe = lstLevo.SelectedItem as Poim;
            tempList.Remove(qwe);

            List<Poim> tempList2 = new List<Poim>();

            for (int i = 0; i < tempList.Count; i++)
                tempList2.Add(new Poim { Value = tempList[i].Value, Ind = tempList[i].Ind });
            lstLevo.Items.Clear();
            lstLevo.Items.AddRange(tempList2.ToArray());
            lstLevo.DisplayMember = "Value";
            lstLevo.ValueMember = "Ind";
        }

        private void fillRight()
        {
            List<Poim> tempList = new List<Poim>();
            for (int i = 0; i < lstDesno.Items.Count; i++)
            {
                tempList.Add(lstDesno.Items[i] as Poim);
            }
            Poim qwee = lstDesno.SelectedItem as Poim;
            tempList.Remove(qwee);

            List<Poim> tempList2 = new List<Poim>();

            for (int i = 0; i < tempList.Count; i++)
                tempList2.Add(new Poim { Value = tempList[i].Value, Ind = tempList[i].Ind });
            lstDesno.Items.Clear();
            lstDesno.Items.AddRange(tempList2.ToArray());
            lstDesno.DisplayMember = "Value";
            lstDesno.ValueMember = "Ind";
        }

        private void check()
        {
           if(lstDesno.SelectedIndex!=-1 && lstLevo.SelectedIndex != -1)
            if (lstDesno.SelectedItem != null && lstLevo.SelectedItem != null)
            {
                if ((lstLevo.SelectedItem as Poim).Ind == (lstDesno.SelectedItem as Poim).Ind)
                {
                    fillLeft();
                    fillRight();
                    addPoints();
                    lstLevo.SelectedIndex = -1;
                    lstDesno.SelectedIndex = -1;

                        if (lstLevo.Items.Count == 0 && lstDesno.Items.Count == 0)
                        {
                            kraj1 = kraj1.OrderBy(x => x.Ind).ToList();
                            kraj2 = kraj2.OrderBy(x => x.Ind).ToList();

                            lstLevo.Items.AddRange(kraj1.ToArray());
                            lstDesno.Items.AddRange(kraj2.ToArray());
                            txtBoxSign.Text =
                                "<======>\n" +
                                "<======>\n" +
                                "<======>\n" +
                                "<======>\n" +
                                "<======>\n" +
                                "<======>\n" +
                                "<======>\n" +
                                "<======>\n" +
                                "<======>\n" +
                                "<======>";
                            txtBoxOpis.Visible = false;
                            btnPravila.Visible = false;
                            txtBoxSign.Visible = true;
                            txtBoxSign.Enabled = false;
                            lstLevo.Enabled = false;
                            lstDesno.Enabled = false;
                            btnNextGame.Enabled = true;
                        }
                }
                else
                {
                         takePoints();
                        lstLevo.SelectedIndex = -1;
                        lstDesno.SelectedIndex = -1;
                }
            }   
        }

        private void addPoints()
        {
            Int32.TryParse(lblPoeni.Text, out points);
            points += 10;
            lblPoeni.Text = points.ToString();
        }

        private void takePoints()
        {
            Int32.TryParse(lblPoeni.Text, out points);
            points -=  5;
            lblPoeni.Text = points.ToString();
        }

        private void btnPravila_Click(object sender, EventArgs e)
        {
            Pravila pr = new Pravila();
            pr.StartPosition = FormStartPosition.CenterParent;
            pr.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnNextGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            asocijacii = new Asocijacii(this.points, this.korisnickoIme);
            asocijacii.Show();
        }
    }
}