using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator.Services
{
    public class ImportantService : IImportantService
    {
        public void DoImportantWork()
        {
            Console.WriteLine("Doing some important work...");
        }
    }
}
