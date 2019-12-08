
using System;
using ServiceLocator.Services;

namespace SimpleDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Container.Register<IUselessService, UselessService>(Lifetime.Singleton);
            Container.Register<IImportantService, ImportantService>(Lifetime.Transient);
            
            var uselessService = Container.Resolve<IUselessService>();
            var importantService = Container.Resolve<IImportantService>();

            uselessService.DoUselessWork();
            importantService.DoImportantWork();

            Console.WriteLine("End of example!");
        }
    }
}
