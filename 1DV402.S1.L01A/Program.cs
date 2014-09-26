using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1.L01A
{
    class Program
    {
        static void Main(string[] args)
        {
            double total;
            int cash;
            uint subtotal;
            double rounding;
            int change;

            while (true)
            {
                try
                {
                    // Läs in totalsumma
                    Console.WriteLine("Ange köpets totalsumma:");
                    total = double.Parse(Console.ReadLine());
                    break;
                }
                // Vid ev fel
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Vänligen ange totalsumman igen");
                    Console.ResetColor();
                }
            }
            // Avrunda inmatad totalsumma till närmsta hela krontal
            subtotal = (uint)Math.Round(total);
            rounding = subtotal - total;
            // Om summan är mindre än 1 - felmeddelande
            if (subtotal < 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Totalsumman är för liten. Köpet kunde inte genomföras.");
                Console.ResetColor();
                return;
            }
            while (true)
            {
                try
                {
                    // Läs in erhållet belopp
                    Console.WriteLine("Ange erhållet belopp:");
                    cash = int.Parse(Console.ReadLine());
                    break;
                }
                // Vid ev fel
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Vänligen ange beloppet igen");
                    Console.ResetColor();
                }
            }
            // Om summan är större än erhållet belopp - felmeddelande
            if (subtotal > cash)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Erhållet belopp är för litet. Köpet kunde inte genomföras.");
                Console.ResetColor();
                return;
            }
            // Skriv ut kvitto...                   
            Console.WriteLine("KVITTO");
            Console.WriteLine("---------------------------");
            // ..totala summan...
            Console.WriteLine("Totalt: " + total);
            // ..öresavrundning...
            Console.WriteLine("Öresavrundning : {0:f2}", rounding);
            // ..summan efter öresavrundning...
            Console.WriteLine("Att betala : {0:f2}", subtotal);
            // ..erhållet belopp...
            Console.WriteLine("Kontant : " + cash);
            // ..växeln som ska ges...
            change = cash - (int)subtotal;
            Console.WriteLine("Tillbaka : " + change);
            // ..växeln uppdelad i olika valörer...
            Console.WriteLine("---------------------------");

            int fiveHundred;
            int hundred;
            int fifty;
            int twenty;
            int ten;
            int five;
            int one;

            fiveHundred = change / 500;
            change %= 500;
            hundred = change / 100;
            change %= 100;
            fifty = change / 50;
            change %= 50;
            twenty = change / 20;
            change %= 20;
            ten = change / 10;
            change %= 10;
            five = change / 5;
            change %= 5;
            one = change / 1;
            change %= 1;

            if (fiveHundred > 0)
            {
                Console.WriteLine("500-lappar : " + fiveHundred);
            }
            if (hundred > 0)
            {
                Console.WriteLine("100 lappar : " + hundred);
            }
            if (fifty > 0)
            {
                Console.WriteLine("50-lappar : " + fifty);
            }
            if (twenty > 0)
            {
                Console.WriteLine("20-lappar : " + twenty);
            }
            if (ten > 0)
            {
                Console.WriteLine("10-kronor : " + ten);
            }
            if (five > 0)
            {
                Console.WriteLine("5-kronor : " + five);
            }
            if (one > 0)
            {
                Console.WriteLine("1-kronor : " + one);
            }
        }
    }
}
