using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Haromszog : Sokszog
    {
        private double b;
        private double c;
        private static Random rnd = new Random();

        public Haromszog(double a, double b, double c) : base(a)
        {
            this.b = b;
            this.c = c;
            if (!IsSzerkeztheto())
            {
                throw new ArgumentException("A háromszög nem szerkezthető!");
            }

        }
        public Haromszog() : base(VeletlenOldalhossz())
        {
            this.b = VeletlenOldalhossz();
            this.c = VeletlenOldalhossz();
            while (!this.IsSzerkeztheto())
            {  
                this.A = VeletlenOldalhossz();
                this.b = VeletlenOldalhossz();
                this.c = VeletlenOldalhossz();
            }
        }

        private static int VeletlenOldalhossz()
        {
            return rnd.Next(1, 15);
        }
        public override double A
        {
            
            set
            {
                base.A= value;
                if (!IsSzerkeztheto())
                {
                    throw new ArgumentException("A háromszög nem szerkezthető", nameof(value));
                }
            }

        }

        public double B 
        { 
            get => b; 
            set {
                b = value;
                if(!IsSzerkeztheto())
                {
                    throw new ArgumentException("A háromszög nem szerkezthető", nameof(value));
                }
                }
                
        }
        public double C
        {
            get => c;
            set
            {
                c = value;
                if (!IsSzerkeztheto())
                {
                    throw new ArgumentException("A háromszög nem szerkezthető", nameof(value));
                }
            }

        }


        private bool IsSzerkeztheto()
        {
            return this.A + this.b > this.c
                && this.A + this.c > this.b
                && this.c + this.b > this.A;
        }

        public override double GetKerulet()
        {
            return this.A + this.b + this.C;
        }
        public override double GetTerulet()
        {
            double s = this.GetKerulet() / 2;
            return Math.Sqrt(s * (s - A) * (s - b) * (s - c));
        }
        public override string ToString()
        {
            return $"a: {this.A} -b: {this.b} - c: {this.c} - {base.ToString()}";
        }
    }

}
