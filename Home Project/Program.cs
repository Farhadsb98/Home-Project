using Home_Project.DataModel;
using Home_Project.Meneger;

namespace Home_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
           AuthorMeneger authormeneger = new AuthorMeneger();
            Author author= new Author();
            BookMeneger bookmeneger= new BookMeneger();
            Book book = new Book();


            authormeneger.Add(author);

            foreach (var item in authormeneger) 
            {
                Console.WriteLine(item);
            }


        }
    }
}