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
            //repo.Add(new Cat() { Name = "Minou", HasClaw = true });
            //repo.Add(new Bird() { Name = "pitpit", FeatherColor = "Red" });

            var cats = repo.Get().OfType<Cat>().ToList();

        }
    }
}
