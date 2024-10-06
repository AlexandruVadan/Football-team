using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3ex7._0
{
    class Persoana
    {
        string cnp;
        string nume;
        string post;

        public Persoana(string cnp, string nume, string post)
        {
            this.Cnp = cnp;
            this.Nume = nume;
            this.Post = post;
        }

        public string Cnp { get => cnp; set => cnp = value; }
        public string Nume { get => nume; set => nume = value; }

        public string Post { get => post; set => post = value; }
    }
}
