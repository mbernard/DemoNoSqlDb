using DemoPoly.Models;
using DemoPoly.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoly
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new AnimalRepository();

            // ==================
            // Initialization
            // ==================
            //InsertSomeData(repo);


            // ==================
            // Queries
            // ==================
            Query(repo);

            Console.Read();
        }

        private static void Query(AnimalRepository repo)
        {
            // by type
            var cats = repo.Get().OfType<Cat>().ToList();
            PrintCollection(cats, "All cats");

            // by attributes
            var catsWithClaws = repo.Get().OfType<Cat>().Where(x => x.HasClaw).ToList();
            PrintCollection(catsWithClaws, "Cats with claws");

            // by shared attributes
            var animalNamed2 = repo.Get().Where(x => x.Name.Contains("2")).ToList();
            PrintCollection(animalNamed2, "Animals with 2 in thier names");
        }

        private static void PrintCollection(IEnumerable<Animal> animals, string title)
        {
            Console.WriteLine(title);
            Console.WriteLine("===============");
            foreach (var o in animals)
            {
                Console.WriteLine(o.Name);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private static void InsertSomeData(AnimalRepository repo)
        {
            repo.Add(new Cat() { Id = 1, Name = "Minou1", HasClaw = true });
            repo.Add(new Cat() { Id = 2, Name = "Minou2", HasClaw = false });
            repo.Add(new Cat() { Id = 3, Name = "Minou3", HasClaw = true });
            repo.Add(new Cat() { Id = 4, Name = "Minou4", HasClaw = false });

            repo.Add(new Bird() { Id = 5, Name = "pitpit1", FeatherColor = "Red" });
            repo.Add(new Bird() { Id = 6, Name = "pitpit2", FeatherColor = "Blue" });
            repo.Add(new Bird() { Id = 7, Name = "pitpit3", FeatherColor = "White" });
            repo.Add(new Bird() { Id = 8, Name = "pitpit4", FeatherColor = "Black" });
        }
    }
}
