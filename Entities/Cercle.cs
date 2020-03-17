using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_HERITAGE.Entities
{
    class Cercle : IForme
    {
        private int rayon;

        public Cercle()
        {

        }

        public Cercle(int r)
        {
            this.rayon = r;
        }

        public int Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        public double perimetre()
        {
            return 2 * 3.14 * rayon;
        }

        public double aire()
        {
            return 3.14 * rayon * rayon;
        }

        public override string ToString()
        {
            return "Cercle de rayon " + this.rayon + Environment.NewLine + "Aire = " + this.aire() + Environment.NewLine + "Périmètre = " + this.perimetre()+Environment.NewLine;
        }

    }

}
