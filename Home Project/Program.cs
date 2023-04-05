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
            int id;

            Console.WriteLine("### Edeceyiniz emeliyyati daxil edin ###");
            var selectMenu = Helper.ReadEnum<MenuType>("Menu:");
           
            l1:
            switch (selectMenu)
            {
                case MenuType.AuthorAdd:
                    var author = new Author();
                    author.Name = Helper.ReadString("Muellifin adi:");
                    authormeneger.Add(author);

                    Console.WriteLine("### Edeceyiniz emeliyyati daxil edin ###");
                     selectMenu = Helper.ReadEnum<MenuType>("Menu:");
                    goto l1;
                case MenuType.AuthorEdit:
                   
                    Console.WriteLine("Redakte etmek istediyiniz muellifi secin");
                    foreach (var item in authormeneger)
                    {
                        Console.WriteLine(item);

                    }
                    id = Helper.ReadInt("Muellifin Id-si:");
                    author=authormeneger.getbyid(id);
                    //if (author==null)
                    //{
                    //    Console.Clear();
                    //    goto case MenuType.AuthorEdit;

                    //}
                    author.Name = Helper.ReadString("Muellifin adi:");
                    Console.Clear();
                    goto case MenuType.AuthorGetAll;


                    
                case MenuType.AuthorRemove:
                    Console.WriteLine("Silmek istediyiniz muellifi secin");
                    foreach (var item in authormeneger)
                    {
                        Console.WriteLine(item);

                    }
                    id = Helper.ReadInt("Muellif ID");
                    author = authormeneger.getbyid(id);
                    if (author == null)
                    {
                        Console.Clear();
                        goto case MenuType.AuthorRemove;


                    }
                    authormeneger.Remove(author);
                    Console.Clear();
                    goto case MenuType.AuthorGetAll;

                case MenuType.AuthorGetAll:
                    Console.Clear();
                    foreach (var item in authormeneger)
                    {
                        Console.WriteLine(item);

                    }
                    Console.WriteLine("### Edeceyiniz emeliyyati daxil edin ###");
                    selectMenu = Helper.ReadEnum<MenuType>("Menu:");

                    goto l1;
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
                    Console.WriteLine("Redakte etmek istediyiniz kitabi secin");
                    foreach (var item in bookmeneger)
                    {
                        Console.WriteLine(item);

                    }
                    id = Helper.ReadInt("Muellif ID");
                    book = bookmeneger.getbyid(id);
                    if (book == null)
                    {
                        Console.Clear();
                        goto case MenuType.BookEdit;

                    }
                    book.Name = Helper.ReadString("Kitabin adi:");
                    Console.Clear();
                    goto case MenuType.BookGetAll;

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