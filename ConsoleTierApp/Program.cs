using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTierApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var data = StudentService.GetNames().ToList();
            foreach (var name in data)
            {
                Console.WriteLine(name);
            }
        }
    }
}
