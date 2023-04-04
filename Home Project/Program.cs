using Home_Project.DataModel;
using Home_Project.Enums;
using Home_Project.genre;
using Home_Project.Helpers;
using Home_Project.Meneger;

namespace Home_Project
{
    internal class Program
    {
        static void Main(string[] args)

        {
            AuthorMeneger authormeneger= new AuthorMeneger();
            BookMeneger bookmeneger= new BookMeneger();

            Console.WriteLine("### Edeceyiniz emeliyyati daxil edin ###");
            var selectMenu = Helper.ReadEnum<MenuType>("Menu:");
            switch (selectMenu)
            {
                case MenuType.AuthorAdd:
                    var author = new Author();
                    author.Name = Helper.ReadString("Muellifin adi:");
                    authormeneger.Add(author);
                    break;
                case MenuType.AuthorEdit:
                    break;
                case MenuType.AuthorRemove:
                    break;
                case MenuType.AuthorGetAll:
                    break;
                case MenuType.AuthorFindbyName:
                    break;
                case MenuType.AuthorGetbyId:
                    break;
                case MenuType.BookAdd:
                    var book = new Book();
                    book.Name = Helper.ReadString("Kitabin adi:");
                    bookmeneger.Add(book);
                    break;
                case MenuType.BookEdit:
                    break;
                case MenuType.BookRemove:
                    break;
                case MenuType.BookGetAll:
                    break;
                case MenuType.BookFindbyName:
                    break;
                case MenuType.BookGetbyId:
                    break;
                default:
                    break;
            }

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