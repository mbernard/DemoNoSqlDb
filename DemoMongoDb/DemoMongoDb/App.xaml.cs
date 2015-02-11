using DemoMongoDb.Models;
using DemoMongoDb.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DemoMongoDb
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var repo = new AnimalRepository();

            // ==================
            // Initialization
            // ==================
            //this.InsertSomeData(repo);    



            // ==================
            // Queries
            // ==================

            // by type
            var cats = repo.Get().OfType<Cat>().ToList();

            // by attributes
            var catsWithClaw = repo.Get().OfType<Cat>().Where(x => x.HasClaw);

            // by shared attributes
            var animal = repo.Get().Where(x => x.Name.Contains("1"));
        }

        private void InsertSomeData(AnimalRepository repo)
        {
            repo.Add(new Cat() { Name = "Minou1", HasClaw = true });
            repo.Add(new Cat() { Name = "Minou2", HasClaw = false });
            repo.Add(new Cat() { Name = "Minou3", HasClaw = true });
            repo.Add(new Cat() { Name = "Minou4", HasClaw = false });

            repo.Add(new Bird() { Name = "pitpit1", FeatherColor = "Red" });
            repo.Add(new Bird() { Name = "pitpit2", FeatherColor = "Blue" });
            repo.Add(new Bird() { Name = "pitpit3", FeatherColor = "White" });
            repo.Add(new Bird() { Name = "pitpit4", FeatherColor = "Black" });
        }
    }
}
