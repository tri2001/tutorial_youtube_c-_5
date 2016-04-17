using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_1
{
    class Program
    {
        static string USER = "george";
        static string PAROLA = "avion";

        static void Main(string[] args)
        {
            Console.WriteLine("Calculator cu Autentificare!\n");

            AutentificareUtilizator();

            while (true)
            {
                RulareCalculator();
            }
        }

        static void AutentificareUtilizator()
        {
            string inputUser = "";
            string inputParola = "";
            int numarIncercari = 0;
            bool autentificat = false;

            do
            {
                Console.WriteLine("");
                Console.Write("Introduceti userul: ");
                inputUser = Console.ReadLine();
                Console.Write("Introduceti parola: ");
                inputParola = Console.ReadLine();
                numarIncercari++;

                autentificat = (inputUser == USER && inputParola == PAROLA);
            }
            while (!autentificat && numarIncercari < 3);

            if (autentificat)
            {
                Console.WriteLine("Autentificare reusita! Apasati orice tasta!");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("Autentificare esuata! Apasati orice tasta pentru a iesi din program.");
                Console.ReadKey(true);
                Environment.Exit(0);
            }            
        }

        static void RulareCalculator()
        {
            char operatieSelectata = ' ';

            Console.WriteLine("\n\nAlegeti o optiune:\n");
            Console.WriteLine("1: Adunare");
            Console.WriteLine("2: Scadere");
            Console.WriteLine("3: Inmultire");
            Console.WriteLine("4: Impartire");
            Console.WriteLine("\n0: Iesire");

            operatieSelectata = Console.ReadKey().KeyChar;

            if (operatieSelectata == '0')
            {
                Console.WriteLine("Ati ales sa iesiti din program! Apasati orice tasta");
                Console.ReadKey(true);
                Environment.Exit(0);
            }
            else
            {
                int numar1 = 0;
                int numar2 = 0;

                Console.Write("Introdu primul numar:");

                try
                {
                    numar1 = int.Parse(Console.ReadLine());
                }
                catch (Exception exceptie)
                {
                    Console.WriteLine("Numarul introdus nu este corect! Apasa orice tasta pentru a incepe din nou!");
                    Console.ReadKey(true);
                    return;
                }

                Console.Write("Introdu al doilea numar:");

                try
                {
                    numar2 = int.Parse(Console.ReadLine());
                }
                catch (Exception exceptie)
                {
                    Console.WriteLine("Numarul introdus nu este corect! Apasa orice tasta pentru a incepe din nou!");
                    Console.ReadKey(true);
                    return;
                }

                // calculam rezultatul

                int rezultat = 0;

                switch (operatieSelectata)
                {
                    case '1':
                        rezultat = numar1 + numar2;
                        break;
                    case '2':
                        rezultat = numar1 - numar2;
                        break;
                    case '3':
                        rezultat = numar1 * numar2;
                        break;
                    case '4':
                        rezultat = numar1 / numar2;
                        break;
                }

                Console.WriteLine("Rezultatul este: " + rezultat);
                Console.WriteLine("Apasa orice tasta pentru a continua");
                Console.ReadKey(true);
            }
        }
    }
}
