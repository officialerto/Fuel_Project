using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLE DEFINITIONS  (DEĞİŞKEN TANIMLAMALARI)
            double diesel = 23.89, fuel = 20.16, lpg = 10.63;
            double tankdiesel = 1000, tankfuel = 1000, tanklpg = 1000;
            double salesquantity = 0;   //Satış Miktarı

            char mainmenuselection = '0', submenuselection = '0', updateliquidprice = '0', liquidsalestype = '0';

        //CREATE MAIN MENU
        //'MENU' is the goto's statement. The 'goto' is C#  unconditional jump statement.
        //When encountered, program flow jumps to the location specified by the goto.
        MENU:

            Console.WriteLine("Liquid Sales Tracking");   //Akaryakıt Satışı Yap
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1- Show Unit Price");
            Console.WriteLine("2- Update Unit Price");  //Birim Fiyat Güncelle
            Console.WriteLine("3- Sell Fuel");
            Console.WriteLine("4- Show Warehouse Status");  //Depo Durumunu Göster
            Console.WriteLine("5- Show Total Sales");
            Console.WriteLine("6- Exit");

            Console.WriteLine("Make Your Choice [1,2,3,4,5,6]: ");
            //Everything which entered keyboard, string
            mainmenuselection = Convert.ToChar(Console.ReadLine());

            if (mainmenuselection == '1')
            {
                //Clear Console Screen
                Console.Clear();
                Console.WriteLine(">> Choose: 1");
                Console.WriteLine("--- List of Unit Price ---");
                Console.WriteLine("Diesel (D): {0} TL/Liter", diesel);
                Console.WriteLine("Fuel (F): {0} TL/Liter", fuel);
                Console.WriteLine("LPG (L): {0} TL/Liter", lpg);

            SUBMENU:

                Console.WriteLine("Choose Your Option [1- Return to Main Menu 2- Close Program]: ");
                submenuselection = Convert.ToChar(Console.ReadLine());

                if (submenuselection == '1')
                {
                    Console.Clear();
                    goto MENU; //Go to up
                }
                else if (submenuselection == '2')
                {
                    //The Environment.Exit() method terminates the process and returns an exit code to the operating system
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You Chose Out Of Options 1, 2!");
                    goto SUBMENU;
                }

            }

            else if (mainmenuselection == '2')
            {
                Console.Clear();
                Console.WriteLine(">> Choose: 2");
                Console.WriteLine("--- Update Unit Price ---");

            LIQUIDTYPE:

                Console.WriteLine("Choose Liquid Type [D,F,L]: ");
                updateliquidprice = Convert.ToChar(Console.ReadLine());

                if (updateliquidprice == 'D' || updateliquidprice == 'd')
                {
                    Console.WriteLine("Diesel [D]:{0} TL/Liter", diesel);
                    Console.WriteLine("Enter New Price for Diesel: ");
                    diesel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Change Applied!");
                    Console.WriteLine("Diesel [D]:{0} TL/Liter", diesel);
                }

                else if (updateliquidprice == 'F' || updateliquidprice == 'f')
                {
                    Console.WriteLine("Fuel [F]:{0} TL/Liter", fuel);
                    Console.WriteLine("Enter New Price for Fuel: ");
                    fuel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Change Applied!");
                    Console.WriteLine("Fuel [F]:{0} TL/Liter", fuel);
                }

                else if (updateliquidprice == 'L' || updateliquidprice == 'l')
                {
                    Console.WriteLine("LPG [L]:{0} TL/Liter", lpg);
                    Console.WriteLine("Enter New Price for LPG: ");
                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Change Applied!");
                    Console.WriteLine("LPG [L]:{0} TL/Liter", lpg);
                }

                else
                {
                    Console.WriteLine("You Chose Out Of Options D, F, L!");
                    goto LIQUIDTYPE;
                }

            SUBMENU:

                Console.WriteLine("Choose Your Option [1- Return to Main Menu 2- Close Program]: ");
                submenuselection = Convert.ToChar(Console.ReadLine());

                if (submenuselection == '1')
                {
                    Console.Clear();
                    goto MENU; //Go to up
                }
                else if (submenuselection == '2')
                {
                    //The Environment.Exit() method terminates the process and returns an exit code to the operating system
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You Chose Out Of Options 1, 2!");
                    goto SUBMENU;
                }
            }

            else if (mainmenuselection == '3')
            {
                Console.Clear();
                Console.WriteLine(">> Choose: 3");
                Console.WriteLine("--- Sell Fuel ---");

            LIQUIDSELL:

                Console.WriteLine("Choose Liquid Type[D,F,L]: ");
                liquidsalestype = Convert.ToChar(Console.ReadLine());
                
                if(liquidsalestype=='D' || liquidsalestype == 'd')
                {
                    if (tankdiesel == 0)
                    {
                        Console.WriteLine("There is No Diesel Left in the Tank.");
                        goto MENU;
                    }

                    else
                    {
                        Console.WriteLine("How Much Diesel Will You Get?");
                        salesquantity = Convert.ToDouble(Console.ReadLine());

                        if (tankdiesel < salesquantity)
                        {
                            Console.WriteLine("There is {0} Liter Diesel in The Tank.", tankdiesel);
                            goto MENU;
                        }

                        else if (salesquantity <= tankdiesel)
                        {
                            tankdiesel = tankdiesel - salesquantity;
                            Console.WriteLine("Refueling Completed.");
                            Console.WriteLine("There is {0} Liter Diesel in The Tank.", tankdiesel);
                        }

                    }

                }

                else if (liquidsalestype == 'F' || liquidsalestype == 'f')
                {
                    if (tankfuel == 0)
                    {
                        Console.WriteLine("There is No Fuel Left in the Tank.");
                        goto MENU;
                    }

                    else
                    {
                        Console.WriteLine("How Much Fuel Will You Get?");
                        salesquantity = Convert.ToDouble(Console.ReadLine());

                        if (tankfuel < salesquantity)
                        {
                            Console.WriteLine("There is {0} Liter Fuel in The Tank.", tankfuel);
                            goto MENU;
                        }

                        else if (salesquantity <= tankfuel)
                        {
                            tankfuel = tankfuel - salesquantity;
                            Console.WriteLine("Refueling Completed.");
                            Console.WriteLine("There is {0} Liter Fuel in The Tank.", tankfuel);
                        }

                    }

                }

                else if (liquidsalestype == 'L' || liquidsalestype == 'l')
                {
                    if (tanklpg == 0)
                    {
                        Console.WriteLine("There is No LPG Left in the Tank.");
                        goto MENU;
                    }

                    else
                    {
                        Console.WriteLine("How Much LPG Will You Get?");
                        salesquantity = Convert.ToDouble(Console.ReadLine());

                        if (tanklpg < salesquantity)
                        {
                            Console.WriteLine("There is {0} Liter LPG in The Tank.", tanklpg);
                            goto MENU;
                        }

                        else if (salesquantity <= tanklpg)
                        {
                            tanklpg = tanklpg - salesquantity;
                            Console.WriteLine("Refueling Completed.");
                            Console.WriteLine("There is {0} Liter LPG in The Tank.", tanklpg);
                        }

                    }

                }

                else
                {
                    Console.WriteLine("You Chose Out Of Options [D,B,L]!");
                    goto LIQUIDSELL;
                }

            SUBMENU:

                Console.WriteLine("Choose Your Option [1- Return to Main Menu 2- Close Program]: ");
                submenuselection = Convert.ToChar(Console.ReadLine());

                if (submenuselection == '1')
                {
                    Console.Clear();
                    goto MENU; //Go to up
                }
                else if (submenuselection == '2')
                {
                    //The Environment.Exit() method terminates the process and returns an exit code to the operating system
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You Chose Out Of Options 1, 2!");
                    goto SUBMENU;
                }
            }

            else if (mainmenuselection == '4')
            {
                Console.Clear();
                Console.WriteLine(">> Choose: 4");
                Console.WriteLine("--- Show Warehouse Status ---");

                Console.WriteLine("Diesel Tank is {0}% Full. ", (tankdiesel/10));
                Console.WriteLine("Fuel Tank is {0}% Full. ", (tankfuel / 10));
                Console.WriteLine("LPG Tank is {0}% Full. ", (tanklpg / 10));

            SUBMENU:

                Console.WriteLine("Choose Your Option [1- Return to Main Menu 2- Close Program]: ");
                submenuselection = Convert.ToChar(Console.ReadLine());

                if (submenuselection == '1')
                {
                    Console.Clear();
                    goto MENU; //Go to up
                }
                else if (submenuselection == '2')
                {
                    //The Environment.Exit() method terminates the process and returns an exit code to the operating system
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You Chose Out Of Options 1, 2!");
                    goto SUBMENU;
                }
            }

            else if (mainmenuselection == '5')
            {
                Console.Clear();
                Console.WriteLine(">> Choose: 5");
                Console.WriteLine("--- Show Total Sales ---");

                Console.WriteLine("Total Diesel Sold:{0} Liter", 1000-tankdiesel);
                Console.WriteLine("Diesel Amount:{0} €", (1000-tankdiesel)*diesel);
                Console.WriteLine("");

                Console.WriteLine("Total Fuel Sold:{0} Liter", 1000 - tankfuel);
                Console.WriteLine("Fuel Amount:{0} €", (1000 - tankfuel) * fuel);
                Console.WriteLine("");

                Console.WriteLine("Total LPG Sold:{0} Liter", 1000 - tanklpg);
                Console.WriteLine("LPG Amount:{0} €", (1000 - tanklpg) * lpg);
                Console.WriteLine("");

                Console.WriteLine("_________________________________________");
                Console.WriteLine("Total Sold:{0} €", ((1000 - tankdiesel) * diesel) + ((1000 - tankfuel) * fuel) + ((1000 - tanklpg) * lpg) );

            SUBMENU:

                Console.WriteLine("Choose Your Option [1- Return to Main Menu 2- Close Program]: ");
                submenuselection = Convert.ToChar(Console.ReadLine());

                if (submenuselection == '1')
                {
                    Console.Clear();
                    goto MENU; //Go to up
                }
                else if (submenuselection == '2')
                {
                    //The Environment.Exit() method terminates the process and returns an exit code to the operating system
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You Chose Out Of Options 1, 2!");
                    goto SUBMENU;
                }
            }

            else if (mainmenuselection == '6')
            {
                Environment.Exit(0);
            }


        }
    }
}
