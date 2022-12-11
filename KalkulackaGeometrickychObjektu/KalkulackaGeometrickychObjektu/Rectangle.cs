using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulackaGeometrickychObjektu
{
    public class Rectangle : ObjectWithACorner, IPlanar
    {
        public override void CalculateTheContent()
        {
            FindOutSide("délku", "obdélníku", out double sideA);
            FindOutSide("šířku", "obdélníku", out double sideB);
            double S = sideA * sideB;
            Console.WriteLine("Obsah obdélníku je:{0} čtverečných centimetrů.", S);
        }

        public void CalculateThePerimetr()
        {
            FindOutSide("délku", "obdélníku", out double sideA);
            FindOutSide("šířku", "obdélníku", out double sideB);
            double O = 2 * sideA + 2 * sideB;
            Console.WriteLine("Obvod obdélníku je:{0} centimetrů.", O);
        }
    }
}
