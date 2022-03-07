using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nelinurk
{
    public class Nelinurk
    {
        double pindala;
        double korgus;
        double laius;
        double type;

        public Nelinurk() { }
        public Nelinurk(double korgus, double laius)
        {
            this.korgus = korgus;
            this.laius = laius;
        }
        public double Korgus 
        {
            get
            {
                return korgus;
            }
            set
            {
                korgus = value;
            }
        }

    }
}
