using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulackaGeometrickychObjektu
{
    public class Calculator
    {
        public string TheEnd = "Libovolnou klávesou ukončíte program...";
        public string InvalidChoice = "Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.";

        /// <summary>
        /// Vypocita na zakladě vstupu obvod/obsah/objem geometrického objektu(typ ktereho uživatel si vybere v metodě CalcAction)
        /// </summary>
        public void CalcMain() {
            //hlavní cyklus
            char choice = '0';
            while (choice != 6)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Kalkulačka geometrických objektů");
                Console.WriteLine("------------------------------------\n");

                Console.WriteLine("Vyberte si typ objektů pro výpočet:");
                Console.WriteLine("1 - Kruh/koule");
                Console.WriteLine("2 - Čtverec");
                Console.WriteLine("3 - Krychle");
                Console.WriteLine("4 - Obdélník");
                Console.WriteLine("5 - Kvádr");
                Console.WriteLine("6 - Konec\n");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                //reakce na volbu
                switch (choice)
                {
                    case '1':                                           //Kruh
                        char choise1=CalcAction();
                        if (choise1 == '1')               //Obsah 
                        {
                            Circle circle = new Circle();
                            circle.CalculateTheContent();
                        }
                        else if (choise1 == '2')            //Obvod 
                        {
                            Circle circle = new Circle();
                            circle.CalculateThePerimetr();
                        }
                        else if (choise1 == '3')            //Objem 
                        {
                            Circle circle = new Circle();
                            circle.CalculateTheVolume();
                        }
                        else
                            Console.WriteLine(InvalidChoice);
                        break;
                    case '2':                                           //Čtverec
                        char choise2 = CalcAction();
                        if (choise2 == '1')               //Obsah 
                        {
                            Square square= new Square();  
                            square.CalculateTheContent();
                        }
                        else if (choise2 == '2')            //Obvod 
                        {
                            Square square = new Square();
                            square.CalculateThePerimetr();
                        }
                        else if (choise2 == '3')            //Objem 
                        {
                            Console.WriteLine("U čtverce nejde vypočitat objem, zkuste krychle.");
                        }
                        else
                            Console.WriteLine(InvalidChoice);
                        break;
                    case '3':                                           //Krychle
                        char choise3=CalcAction();
                        if (choise3 == '1')               //Obsah 
                        {
                            Cube cube=new Cube();
                            cube.CalculateTheContent();
                        }
                        else if (choise3 == '2')            //Obvod 
                        {
                            Console.WriteLine("U kryhle nejde vypočitat obvod, zkuste čtverec.");
                        }
                        else if (choise3 == '3')            //Objem 
                        {
                            Cube cube=new Cube();
                            cube.CalculateTheVolume();
                        }
                        else
                            Console.WriteLine(InvalidChoice);
                        break;
                    case '4':                                               //Obdélník
                        char choise4 = CalcAction();
                        if (choise4 == '1')               //Obsah 
                        {
                            Rectangle rectangle= new Rectangle();
                            rectangle.CalculateTheContent();
                        }
                        else if (choise4 == '2')            //Obvod 
                        {
                            Rectangle rectangle = new Rectangle();
                            rectangle.CalculateThePerimetr();
                        }
                        else if (choise4 == '3')            //Objem 
                        {
                            Console.WriteLine("U obdélníka nejde vypočitat objem, zkuste kvádr.");
                        }
                        else
                            Console.WriteLine(InvalidChoice);
                        break;
                    case '5':                                               //Kvádr
                        char choise5=CalcAction();
                        if (choise5 == '1')               //Obsah 
                        {
                            Block block=new Block();
                            block.CalculateTheContent();
                        }
                        else if (choise5 == '2')            //Obvod 
                        {
                            Console.WriteLine("U kvádru nejde vypočitat obvod, zkuste obdélník.");
                        }
                        else if (choise5 == '3')            //Objem 
                        {
                            Block block = new Block();
                            block.CalculateTheVolume();
                        }
                        else
                            Console.WriteLine(InvalidChoice);
                        break;
                        break;
                    case '6':
                        Console.WriteLine(TheEnd);
                        break;
                    default:
                        Console.WriteLine(InvalidChoice);
                        break;
                }
                Console.ReadKey();
            }
        }
        /// <summary>
        /// Vratí volbu-char (typ operace) pro pro metodu CalcMain pro dálší výpočet
        /// </summary>
        /// <returns>choice2(char) pro metodu CalcMain</returns>
        public char CalcAction()
        {
            char choice = '0';
            while (choice != 4)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Kalkulačka geometrických objektů");
                Console.WriteLine("------------------------------------\n");

                Console.WriteLine("Vyberte si typ operace:");
                Console.WriteLine("1 - Obsah"); //planar
                Console.WriteLine("2 - Obvod"); //planar and spatial
                Console.WriteLine("3 - Objem"); //spatial
                Console.WriteLine("4 - Konec\n");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                //reakce na volbu
                switch (choice)
                {
                    case '1':
                        return '1';
                        break;
                    case '2':
                        return '2';
                        break;
                    case '3':
                        return '3';
                        break;
                    case '4':
                        Console.WriteLine(TheEnd);
                        break;
                    default:
                        Console.WriteLine(InvalidChoice);
                        break;
                }
                Console.ReadKey();
            }
            return '0';
        }
        

    }
}
