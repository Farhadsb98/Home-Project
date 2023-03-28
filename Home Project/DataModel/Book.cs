using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Project.DataModel
{
   public class Book: IEquatable<Book>
    {
        int counter = 0;
        public Book()
        {
            counter++;
            this.Id= counter;
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Authorld { get; set; }  
        public int PageCount { get; set; }
        public decimal Price { get; set; }

        public bool Equals(Book? other)
        {
            return other?.Id == this.Id;
        }

        public override string ToString()
        {
            return $"{Id}:Kitabin adi-{Name} kitabin sehife sayi-{PageCount} kitabin qiymeti-{Price} kitab haqqinda-{Authorld}";
            
        }
    }
}
