using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_HERITAGE.Entities
{
    class Triangle : IForme
    {
        private int a;
        private int b;
        private int c;

        public Triangle()
        {

        }

        public Triangle(int c1, int c2, int c3)
        {
            this.a = c1;
            this.b = c2;
            this.c = c3;
        }


        public int A
        {
            get { return a; }
            set { a = value; }
        }


        public int B
        {
            get { return b; }
            set { b = value; }
        }


        public int C
        {
            get { return c; }
            set { c = value; }
        }

        public double perimetre()
        {
            return a + b + c;

        }

        public double aire()
        {
           double demip = perimetre() / 2;
           return Math.Sqrt(demip*(demip-this.a)*(demip-this.b)*(demip-this.c)); 
        }

        public override string ToString()
        {
            return "Triangle de coté A= " + this.a  + ", B = " + this.b + ", C = " + this.c + Environment.NewLine + "Aire = " + this.aire() + Environment.NewLine + "Périmètre = " + this.perimetre() + Environment.NewLine;
        }

    }
}
