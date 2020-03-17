using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_HERITAGE.Entities
{
    class Carre : IForme
    {
        private int longueur;


        public Carre()
        {

        }
        public Carre(int a)
        {
            this.longueur = a;
        }


        public int Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

      
        public double aire()
        {
            return longueur * longueur;
        }

        public double perimetre()
        {
            return 4 * longueur;
        }

        public override string ToString()
        {
            return "Carre de coté " + this.longueur + Environment.NewLine + "Aire = " + this.aire() + Environment.NewLine + "Périmètre = " + this.perimetre() + Environment.NewLine;
        }

    }
}
