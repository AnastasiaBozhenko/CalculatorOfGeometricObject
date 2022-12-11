using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulackaGeometrickychObjektu
{
    public class Square : ObjectWithACorner, IPlanar
    {
        public override void CalculateTheContent()
        {
            FindOutSide("délku strany", "čtverce", out double side);
            double S =Math.Pow(side, 2);
            Console.WriteLine("Obsah čtverce je: {0} čtverečných centimetrů.", S);
        }

        public void CalculateThePerimetr()
        {
            FindOutSide("délku strany", "čtverce", out double side);
            double O = 4 * side;
            Console.WriteLine("Obvod čtverce je: {0} centimetrů.", O);
        }
    }
}
