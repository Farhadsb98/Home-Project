using Home_Project.Enums;

namespace Home_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var menus = Enum.GetValues(typeof(MenuType));

            foreach (var item in menus)
            {
                int id = Convert.ToByte(item);
                Console.WriteLine($"{id.ToString().PadLeft(2,'0')}:{item}");
            }
           //AuthorMeneger authormeneger = new AuthorMeneger();
           // Author author= new Author();
           // BookMeneger bookmeneger= new BookMeneger();
           // Book book = new Book();


           // authormeneger.Add(author);

           // foreach (var item in authormeneger) 
           // {
           //     Console.WriteLine(item);
           // }


        }
    }
}