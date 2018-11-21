using System;
using System.Collections.Generic;
using System.Linq;

namespace dotNetCore.Models
{
    public class Pearson
    {
        public Guid ID { get; protected set; }
        public string Name { get; protected set; }
        public string Subname { get; protected set; }
        public decimal Reward { get; protected set; }
        public string Department { get; protected set; }

        public Pearson(string name, string subname, decimal reward, string department)
        {
            ID=Guid.NewGuid();
            Name=name;
            Subname=subname;
            Reward=reward;
            Department=department;
        }
    }
    public class LINQTest
    {
        public void QueryTesting()
        {
            var Pearsons=GetPearsons();
            var FirstQuery=Pearsons.Where(record=>record.Name!=null).Skip(2).Take(1);
            foreach (var item in FirstQuery)
            {
                Console.WriteLine($"{item.Name}: {item.ID}");
            }
            var SecondQuery=Pearsons.GetEnumerator();
        

        }

        IEnumerable<Pearson> GetPearsons()
        {
            yield return new Pearson("Mateusz","Majer",3000,"IT");
            yield return new Pearson("Łukasz","Majer",3000,"IT");
            yield return new Pearson("Barbara","Majer",3500,"HR");
            yield return new Pearson("Wiesław","Majer",4000,"HR");
            yield return new Pearson("Maria","Majer",1200,"PR");
        }
    }
}