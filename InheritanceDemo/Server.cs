using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Server
    {
        protected List<string> duties;
        protected double wages;
        public string Name { get; }
        public Server(string name)
        {
            Name = name; wages = 14.95;
            duties = new List<string>() {"wipe tables", "empty garbage" , "take order", "make burgers"};
        }
        public override string ToString()
        {
            return $"My name is {Name}, my wages is {wages:C}, my duties are:\n{string.Join(", ", duties)}";
        }
    }
    class Superisor : Server
    {
        public Superisor(string name)
            : base(name)
        {
            wages = 18.25;
            duties.Add("Scheduling");
        }
    }
}
