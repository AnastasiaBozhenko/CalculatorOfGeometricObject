using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulackaGeometrickychObjektu
{
    public abstract class ObjectWithACorner : GeometricObject
    {
        /// <summary>
        /// Strana geometrického objektu v cm
        /// </summary>
        private double Side { get; set; }


        /// <summary>
        /// Zjisti stránu geometrického objektu, jako parametr bere název strany("delky/šiřky/vyšky") a geometrického objektu v 2.pádu a vráci stranu
        /// </summary>
        /// <param NameOfside="NameOfside"></param>
        /// <param gemetricObject="gemetricObject"></param>
        /// <param side="side"></param>
        public void FindOutSide(string NameOfside, string gemetricObject, out double side)
        {
            //Zjisti stranu 
            Console.WriteLine($"Zadejte {NameOfside} {gemetricObject} pro výpočet v cm: ");
            string side_ = "";
            while (true)
            {
                side_ = Console.ReadLine().Trim();
                if (!double.TryParse(side_, out side))
                    Console.WriteLine($"Zadej {NameOfside} znovu:");
                else
                    break;
            }
            if (side < 0)
            {
                Console.WriteLine($"Hodnota {NameOfside} nemůže být zápornou, zadejte nezáporné číslo větší než 0.");
                while (true)
                {
                    side_ = Console.ReadLine().Trim();
                    if (!double.TryParse(side_, out side))
                        Console.WriteLine($"Zadej {NameOfside} znovu:");
                    else
                        break;
                }
            }
        }
       
    }
}
