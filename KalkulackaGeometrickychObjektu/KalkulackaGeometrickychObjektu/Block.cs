using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulackaGeometrickychObjektu
{
    public class Block : ObjectWithACorner, ISpatial
    {
        /// <summary>
        /// Vypočítá 
        /// </summary>
        public override void CalculateTheContent()
        {
            FindOutSide("délku", "obdélníku", out double sideA);
            FindOutSide("šířku", "obdélníku", out double sideB);
            FindOutSide("vyšku", "obdélníku", out double sideC);
            double S = (sideA * sideB + sideB * sideC + sideC * sideA) * 2;
            Console.WriteLine("Obsah kvádru je:{0} čtverečných centimetrů.", S);
        }

        public void CalculateTheVolume()
        {
            FindOutSide("délku", "obdélníku", out double sideA);
            FindOutSide("šířku", "obdélníku", out double sideB);
            FindOutSide("vyšku", "obdélníku", out double sideC);
            double V = sideA * sideB * sideC;
            Console.WriteLine("Objem kvádru je:{0} centimetrů krychlových.", V);
        }
    }
}
