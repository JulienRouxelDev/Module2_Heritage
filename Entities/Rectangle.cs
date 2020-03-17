using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_HERITAGE.Entities
{
    class Rectangle : IForme
    {
        private int largeur;
        private int longueur;

        public Rectangle()
        {

        }
        public Rectangle(int l, int L)
        {
            this.largeur = l;
            this.longueur = L;
        }


        public int Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }

        public int Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public double aire()
        {
            return longueur * largeur;
        }

        public double perimetre()
        {
            return 2 * (longueur + largeur);
        }

        public override string ToString()
        {
            return "Rectangle de longueur=  " + this.longueur + "et largeur = " + this.largeur + Environment.NewLine + "Aire = " + this.aire() + Environment.NewLine + "Périmètre = " + this.perimetre() + Environment.NewLine;
        }

    }
}
