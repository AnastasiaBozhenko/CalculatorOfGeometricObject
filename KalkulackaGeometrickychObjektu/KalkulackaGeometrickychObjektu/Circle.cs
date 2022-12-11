using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulackaGeometrickychObjektu
{
    public  class Circle:ObjectWithoutACorner, IPlanar
    {
        /// <summary>
        /// Vypočitá Objem Kruhu
        /// </summary>
        public override void CalculateTheVolume()
        {
            FindOutRadian(out double r);
            double V = (4 / 3) * pi * Math.Pow(r, 3);
            Console.WriteLine("Objem koule je:{0} centimetrů krychlových.", V);
        }
        /// <summary>
        /// Vypočitá obsah kruhu
        /// </summary>
        public override void CalculateTheContent()
        {
            FindOutRadian(out double r);
            double S = 4*pi* Math.Pow(r, 2);
            Console.WriteLine("Obsah kruhu/koule je:{0} čtverečných centimetrů.", S);
        }
        /// <summary>
        /// Vypočitá Obvod kruhu
        /// </summary>
        public override void CalculateThePerimetr()
        {
            FindOutRadian(out double r);
            double O = 2 * pi * r;
            Console.WriteLine("Obvod kruhu je:{0} centimetrů.", O);
        }
    }
}
