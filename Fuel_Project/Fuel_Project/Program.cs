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
            Console.WriteLine("Liquid Sales Tracking");   //Akaryakıt Satışı Yap
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1- Show Unit Price");
            Console.WriteLine("2- Update Unit Price");  //Birim Fiyat Güncelle
            Console.WriteLine("3- Sell Fuel");
            Console.WriteLine("4- Show Warehouse Status");  //Depo Durumunu Göster
            Console.WriteLine("5- Show Total Sales");
            Console.WriteLine("6- Sell Fuel");
            Console.WriteLine("7- Exit");

            Console.ReadKey();

        }
    }
}
