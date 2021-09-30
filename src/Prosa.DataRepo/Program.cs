using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Prosa.DataRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPersonRepository rep = new PersonRepositoryDynamiskMock();
            //IPersonRepository rep = new PersonRepositoryFilMock("..\\..\\..\\..\\..\\data");
            IPersonRepository rep = new PersonRepositoryProd("..\\..\\..\\..\\..\\data");
            rep.HentPersoner().ForEach(i => Console.WriteLine(i));
        }
    }

    public class Person
    {
        public string Navn { get; set; }
        public string By { get; set; }
        public bool IForm { get; set; }
        public int Alder { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }
    }

    public interface IPersonRepository
    {
        List<Person> HentPersoner();
    }

    public class PersonRepositoryFilMock : IPersonRepository
    {
        private readonly string sti;

        public PersonRepositoryFilMock(string sti)
        {
            this.sti = System.IO.Path.Combine(sti, "mock.csv");
        }
        public List<Person> HentPersoner()
        {
            using (var reader = new StreamReader(sti, Encoding.Default))
            using (var csv = new CsvReader(reader, new CultureInfo("da-DK")))
                return csv.GetRecords<Person>().ToList();
        }
    }

    public class PersonRepositoryProd : IPersonRepository
    {
        private readonly string sti;

        public PersonRepositoryProd(string sti)
        {
            this.sti = System.IO.Path.Combine(sti, "personer.csv");
        }
        public List<Person> HentPersoner()
        {
            using (var reader = new StreamReader(sti, Encoding.Default))
            using (var csv = new CsvReader(reader, new CultureInfo("da-DK")))
                return csv.GetRecords<Person>().ToList();
        }
    }

    public class PersonRepositoryDynamiskMock : IPersonRepository
    {
        private static Random rnd = new Random();
        public List<Person> HentPersoner()
        {
            List<Person> lst = new List<Person>();
            for (int i = 0; i < 100; i++)
            {
                lst.Add(new Person
                {
                    Navn = "Person #" + i,
                    By = "By #" + i,
                    IForm = i % 2 == 0,
                    Alder = i
                });
            }
            return lst;
        }
    }

}
