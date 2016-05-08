using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Asocijacija
    {
        public string[] A { get; set; }
        public string[] B { get; set; }
        public string[] V { get; set; }
        public string[] G { get; set; }
        public string Konecno { get; set; }

        public Asocijacija(string[] A, string[] B, string[] V, string[] G, string Konecno)
        {
            this.A = A;
            this.B = B;
            this.V = V;
            this.G = G;
            this.Konecno = Konecno;
        }
    }
}
