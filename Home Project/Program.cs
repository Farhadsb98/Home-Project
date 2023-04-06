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
                    if (id==0)
                    {
                        Console.WriteLine("### Edeceyiniz emeliyyati daxil edin ###");
                        selectMenu = Helper.ReadEnum<MenuType>("Menu:");

                        goto l1;

                    }
                    author=authormeneger.getbyid(id);
                    if (author == null)
                    {
                        Console.Clear();
                        goto case MenuType.AuthorEdit;

                    }
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
                    id = Helper.ReadInt("Muellifin adi");
                    if (id == 0)
                    {
                        Console.WriteLine("### Edeceyiniz emeliyyati daxil edin ###");
                        selectMenu = Helper.ReadEnum<MenuType>("Menu:");

                        goto l1;

                    }
                    author = authormeneger.getbyid(id);

                    if (author == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Muellif tapilmadi...");
                        goto case MenuType.AuthorGetbyId;


                    }
                    Console.WriteLine(author);
                    goto l1;
                case MenuType.BookAdd:
                    var book = new Book();
                    book.Name = Helper.ReadString("Kitabin adi:");
                    bookmeneger.Add(book);
                    Console.WriteLine("### Edeceyiniz emeliyyati daxil edin ###");
                    selectMenu = Helper.ReadEnum<MenuType>("Menu:");
                    goto l1;
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

                   
                case MenuType.BookRemove:
                    Console.WriteLine("Silmek istediyiniz Kitabi secin");
                    foreach (var item in bookmeneger)
                    {
                        Console.WriteLine(item);

                    }
                    id = Helper.ReadInt("Kitabin Id-si");
                    book = bookmeneger.getbyid(id);
                    if (book == null)
                    {
                        Console.Clear();
                        goto case MenuType.BookRemove;


                    }
                    bookmeneger.Remove(book);
                    Console.Clear();
                    goto case MenuType.BookGetAll;
                    
                case MenuType.BookGetAll:
                    Console.Clear();
                    foreach (var item in bookmeneger)
                    {
                        Console.WriteLine(item);

                    }
                    Console.WriteLine("### Edeceyiniz emeliyyati daxil edin ###");
                    selectMenu = Helper.ReadEnum<MenuType>("Menu:");
                    goto l1;
                case MenuType.BookFindbyName:
                    break;
                case MenuType.BookGetbyId:
                    id = Helper.ReadInt("kitabin adi");
                    if (id == 0)
                    {
                        Console.WriteLine("### Edeceyiniz emeliyyati daxil edin ###");
                        selectMenu = Helper.ReadEnum<MenuType>("Menu:");

                        goto l1;

                    }
                    book = bookmeneger.getbyid(id);

                    if (book == null)
                    {
                        Console.Clear();
                        Console.WriteLine("kitabin tapilmadi...");
                        goto case MenuType.BookGetbyId;


                    }
                    Console.WriteLine(book);
                    goto l1;
                    
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