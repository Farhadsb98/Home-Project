using Home_Project.Enums;
using Home_Project.genre;
using Home_Project.Helpers;

namespace Home_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Edeceyiniz emeliyyati daxil edin ###");
            var selectMenu = EnumHelper.ReadEnum<MenuType>("Menu:");
            Console.WriteLine(selectMenu);

            Console.WriteLine("### Kitabin Janrini Secin ###");
            var Janr = EnumHelper.ReadEnum<Genre>("Janr:");
            Console.WriteLine(Janr);

            //var menus = Enum.GetValues(typeof(MenuType));

            //foreach (var item in menus)
            //{
            //    int id = Convert.ToByte(item);
            //    Console.WriteLine($"{id.ToString().PadLeft(2,'0')}:{item}");
            //}
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