using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulackaGeometrickychObjektu
{
    public abstract class ObjectWithoutACorner:GeometricObject
    {
        /// <summary>
        /// Konstanta Pi pro výpočet
        /// </summary>
        public const double pi = Math.PI;
        /// <summary>
        /// Radian(poloměr)
        /// </summary>
        public double Radian { get; set; }

        public abstract void CalculateThePerimetr();
        public abstract void CalculateTheVolume();

        /// <summary>
        /// Zjisti od uživatele délku radiánu(poloměru) kruhu pro výpočet v cm
        /// </summary>
        /// <param Radian="r"></param>
        public void FindOutRadian(out double r)
        {
            //Zjisti radián
            Console.WriteLine("Zadejte délku radiánu(poloměru) kruhu pro výpočet v cm: ");
            string radian = "";
            while (true)
            {
                radian = Console.ReadLine().Trim();
                if (!double.TryParse(radian, out r))
                    Console.WriteLine("Zadej délku radiánu(poloměru) znovu:");
                else
                    break;
            }
            if (r < 0)
            {
                Console.WriteLine("Hodnota radiánu nemůže být zápornou, zadej nezáporné číslo větší než 0.");
                while (true)
                {
                    radian = Console.ReadLine().Trim();
                    if (!double.TryParse(radian, out r))
                        Console.WriteLine("Zadej délku radiánu(poloměru) znovu:");
                    else
                        break;
                }
            }
        }
    }
}
