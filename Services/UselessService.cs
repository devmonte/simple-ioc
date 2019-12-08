using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator.Services
{
    public class UselessService : IUselessService
    {
        public void DoUselessWork()
        {
            Console.WriteLine("Doing some useless work...");

        }
    }
}
