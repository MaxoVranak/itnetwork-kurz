using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project_Evidencia_Poistencov
{
    class Command
    {
        private Database database;

        public Command()
        {
            database = new Database();
        }

        //add insured
        public void AddInsured()
        {
            string name = PromptNonEmpty("\nZadajte meno poistenca:");
            string surname = PromptNonEmpty("Zadajte priezvisko:");


            //phone number as a string, because int will not show 0 at the beginning if user tries to input phone number that way
            //->only numbers and char '+', spaces are allowed
            //->we will use regex function 

            Console.WriteLine("Zadajte telefónne číslo");
            string phoneNumber;

            //^ start of the line, \+? is optional + at the beginning, \d at least one digit after + or at the start
            //[\d\s]* any number of digits or spaces, $ end of the line
            while (string.IsNullOrWhiteSpace(phoneNumber = Console.ReadLine().Trim()) ||
                !Regex.IsMatch(phoneNumber, @"^\+?\d[\d\s]*$"))
            {
                Console.WriteLine("Error, nesprávne zadané číslo");
            }

            //age
            Console.WriteLine("Zadajte vek: ");
            int age;
            //check if the age is between 0 and 140 range if not repeat
            while (!int.TryParse(Console.ReadLine(), out age) || age == 0 || age > 140)
            {
                Console.WriteLine("Neplatný vek. Skúste znova:");
            }

            database.AddEntry(name, surname, phoneNumber, age);
            Console.WriteLine("\nPoistenec bol úspešne pridaný:");
            Console.WriteLine($"{name}\t{surname}\t{age}\t{phoneNumber}");
            Console.WriteLine("\nStlačte ľubovoľnú klávesu pre pokračovanie...\n");
            Console.ReadKey();

        }
        
        public void WriteInsured()
        {
            database.WriteInsured();
        }

        public void SearchInsured()
        {
            database.SearchInsured();
        }

        //for the name and surname it will be wise to use method that will help not to repeat the code twice = for the input name and surname,
        //->so it prompts the user until the string in non-empty
        private string PromptNonEmpty(string prompt)
        {
            //in this case expecting name or surname, declearing string
            string input;
            Console.WriteLine(prompt);
            //input needs to be something or it repeats question "Zadana hodnota nesmie byt prazdna...", likewise trim excess spaces around the input
            while (string.IsNullOrWhiteSpace(input = Console.ReadLine().Trim()))
            {
                Console.WriteLine("Zadaná hodnota nesmie byť prázdna. Skúste znova.");
            }
            return input;
            //after everything it returns values or rather string that is trimed and will be used in string name and string surname
            //->because that is where our function is called
        }
    }
}
