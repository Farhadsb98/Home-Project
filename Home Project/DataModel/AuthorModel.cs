using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Project.DataModel
{
  public class AuthorModel
    {
        static int counter = 0;
        public AuthorModel()
        {
            counter++;
            this.Id= counter;
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{Id}:{Name} {Surname}";
        }
    }
}
