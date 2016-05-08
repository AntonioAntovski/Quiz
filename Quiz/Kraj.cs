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
    public partial class Kraj : Form
    {
        public int points;

        public Kraj(int points)
        {
            InitializeComponent();
            this.points = points;
        }
    }
}
