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
    public partial class Pravila : Form
    {
        public Pravila()
        {
            InitializeComponent();
            txtPravila.Text = "Во играта Спојувалка потребно е да ги поврзете соодветно поимите од листата на лево со поимите од листата на десната страна. Секое точно поврзување на два поима се наградува со 10 поени."
                                + " За секое погрешно поврзување се одземаат 5 поени."
                                + " Играта завршува кога сите поими се поврзани соодветно.";
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
