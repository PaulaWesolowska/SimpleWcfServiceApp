using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfService3
{
    //public class Person
    //{
    //     public static void Main()
    //    {
    //        List<People> ppl = new List<People>();
    //        ppl.Add(new People() { firstName = "Elżbieta", lastName = "Kowalska", address = "Bydgoszcz" });
    //        ppl.Add(new People() { firstName = "Jan", lastName = "Nowak", address = "Gdańsk" });
    //        ppl.Add(new People() { firstName = "Karol", lastName = "Wiśniewski", address = "Gdynia" });

    //        void GetPersonData(string lastName)
    //        {
    //            Console.WriteLine("Podaj nazwisko");
    //            for (int i = 0; i < ppl.Count; i++)
    //            {
    //                if (ppl[i].lastName == lastName)
    //                {
    //                    var person = ppl[i];
    //                    Console.WriteLine(person);
    //                }
    //            }
    //        }

    //        List<People> GetList()
    //        {
    //            return ppl;
    //        }
    //    }
    //}

    //internal class People
    //{
    //    public string firstName { get; set; }
    //    public string lastName { get; set; }
    //    public string address { get; set; }
    //}

    public class People
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }


        public string GetData(string lastName)
        {
            List<People> ppl = new List<People>();
            ppl.Add(new People() { firstName = "Elżbieta", lastName = "Kowalska", address = "Bydgoszcz" });
            ppl.Add(new People() { firstName = "Jan", lastName = "Nowak", address = "Gdańsk" });
            ppl.Add(new People() { firstName = "Karol", lastName = "Wiśniewski", address = "Gdynia" });
            // ppl.Find(x => x.lastName == lastName);
            //int i = ppl.FindIndex(p => p.lastName == lastName);
            //string person = ppl.ElementAt(s);
            //return person;

            //var result = from p in ppl
            //             where p.lastName == lastName
            //             select p;
            //return result.ToList();

            var filtered = ppl.Where(item => item.lastName.Equals(lastName)).ToList().ToString();
            return filtered.ToString();
           
            //var person = (from p in ppl
            //              where p.lastName == lastName
            //              select p).ToList();
            //return person.ToString();

            //var mylist = person.ConvertAll(x => x.ToString());
            //return mylist.ToString();

        }

    }
}