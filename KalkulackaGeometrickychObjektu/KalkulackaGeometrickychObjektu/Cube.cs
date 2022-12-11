using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulackaGeometrickychObjektu
{
    public class Cube : ObjectWithACorner, ISpatial
    {
        public override void CalculateTheContent()
        {
            FindOutSide("délku strany", "krychle", out double side);
            double S = 6 * Math.Pow(side, 2);
            Console.WriteLine("Obsah kryhle je:{0} čtverečných centimetrů.", S);
        }

        public void CalculateTheVolume()
        {
            FindOutSide("délku strany", "krychle", out double side);
            double S = 6 * Math.Pow(side, 2);
            Console.WriteLine("Objem kryhle je:{0} centimetrů krychlových.", S);
        }
    }
}
