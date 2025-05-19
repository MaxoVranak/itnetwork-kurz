using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Evidencia_Poistencov
{
    class Database
    {
        private List<Entry> entries;

        public Database()
        {
            entries = new List<Entry>();
        }

        //adding new insured person
        public void AddEntry(string name, string surname, string phoneNumber, int age)
        {
            entries.Add(new Entry(name, surname, phoneNumber, age));
        }

        public void WriteInsured()
        {
            Console.WriteLine();
            //check if there is anything in entries
            if (entries.Count == 0)
            {
                Console.WriteLine("Zatiaľ nie sú pridaní žiadni poistenci.");
                Console.WriteLine("\nStlačte ľubovoľnú klávesu pre pokračovanie...\n");
                Console.ReadKey();
            }


            //write name, surname.... of each insured 
            else
            {
                foreach (var entry in entries)
                {
                    Console.WriteLine(entry);
                }

                Console.WriteLine("\nStlačte ľubovoľnú klávesu pre pokračovanie...");
                Console.ReadKey();
            }
        }

        public void SearchInsured()
        {
            //check if anything is in the entries
            if (entries.Count == 0)
            {
                Console.WriteLine("\nPre vyhľadávanie je potrebné, aby bol aspoň nejaký poistenec v systéme.");
                Console.WriteLine("\nStlačte ľubovoľnú klávesu pre pokračovanie...\n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Zadajte meno: ");
                string searchName = Console.ReadLine().Trim();
                //trim the input of unnecessary spaces
                Console.WriteLine("Zadajte priezvisko: ");
                string searchSurname = Console.ReadLine().Trim();

                //set found as boolean and with value false
                bool found = false;

                //search in entries if there is any match
                foreach (var entry in entries)
                {
                    //if the name and surname matches of the ones that are in the entries than found will et to true
                    //->ignore uppercase format this will get rid of unnecessary trouble
                    //->basically compare the names and surnames in entry with the input ones
                    if (entry.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase) &&
                        entry.Surname.Equals(searchSurname, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(entry);
                        found = true;
                    }
                }

                //no match found
                if (!found)
                {
                    Console.WriteLine("\nPoistenec nebol nájdený.");
                }

                Console.WriteLine("\nStlačte ľubovoľnú klávesu pre pokračovanie...");
                Console.ReadKey();
            }
        }

    }
}
