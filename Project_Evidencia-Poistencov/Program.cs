using Project_Evidencia_Poistencov;

namespace Project_Evidencia_Poistenca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Command command = new Command();
            //Headline
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Evidencia Poistených");
            Console.WriteLine("-------------------------------------------------------");

            //initialize option for the option list
            char option = '0';

            //main cicle
            do
            {
                Console.WriteLine("Vyberte si možnosť: \n");
                Console.WriteLine("1 - Pridať nového poistenca");
                Console.WriteLine("2 - Vypísať všetkých poistencov");
                Console.WriteLine("3 - Vyhladať poistenca");
                Console.WriteLine("4 - Koniec");

                //reading choosed option
                option = Console.ReadKey().KeyChar;
                Console.WriteLine();

                
                switch (option)
                {
                        //add insured person
                    case '1':
                        command.AddInsured();
                        break;
                        //write insured persons
                    case '2':
                        command.WriteInsured();
                        break;
                        //search for insured person in database
                    case '3':
                        command.SearchInsured();
                        break;
                        //END
                    case '4':
                        Console.WriteLine("\nStlačte tlačidlo a pre ukončenie programu...");
                        break;
                        //if selected something other than the offred options
                    default:
                        Console.WriteLine("\nError. Stlačte jednu z ponúk prosím.\n");
                        break;

                }
            } while (option != '4');

            Console.WriteLine("\nDovidenia");
            Console.ReadKey();

        }
    }
}
