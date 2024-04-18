using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KA_2024_04_18
{
    class EredmenyekRepo
    {
        public static string path { get; set; }
        public static bool SkipHeader { get; set; } = true;
        public static char separator { get; set; } = ',';

        public static List<Eredmenyek> FindAll()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                if (SkipHeader)
                    reader.ReadLine();


                List<Person> People = new List<Person>();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Person person = Person.CreateFromLine(line, separator);
                    People.Add(person);

                }

                return People;
            }
        }

        public static List<Person> FindAllBySearch(string FirstName, string LastName, string Email, string Email2, string Job)
        {
            List<Person> people = new List<Person>();

            foreach (Person person in FindAll())
            {

                if (!person.FirstName.ToLower().Contains(FirstName.ToLower().Trim()))
                    continue;
                if (!person.LastName.ToLower().Contains(LastName.ToLower().Trim()))
                    continue;
                if (!person.Email.ToLower().Contains(Email.ToLower().Trim()))
                    continue;
                if (!person.Email2.ToLower().Contains(Email2.ToLower().Trim()))
                    continue;
                if (Job != "" && person.Job != Job)
                    continue;

                people.Add(person);
            }

            return people;
        }


    }
}
