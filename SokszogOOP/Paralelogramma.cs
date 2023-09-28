using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Paralelogramma : Teglalap
    {
        private double alfa;
        private static Random random = new Random();

        public double Alfa { get => alfa;
            set { alfa = value;
                if (alfa<0 && 180<alfa) 
                {
                    throw new ArgumentException("A háromszög nem szerkezthető", nameof(value));
                }
            } }
        public Paralelogramma(): base(VeletlenSzam(),VeletlenSzam())
        {
            this.alfa = VeletlenSzog();
            base.A = VeletlenSzam();
            base.B= VeletlenSzam();
        }
        private static int VeletlenSzam()
        {
            return random.Next(1, 15);
        }
        private static double VeletlenSzog()
        {
            return random.Next(0, 180);
        }
        public override double GetTerulet()
        {
            double radian = alfa / 180;
            return this.A * this.B * Math.Sin(radian);
        }
        public override string ToString()
        {
            return $"a: {this.A} - b:{this.B}- bezárt szög: {this.alfa}-{base.ToString()}";
        }
    }
    
}
