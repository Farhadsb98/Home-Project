using Home_Project.DataModel;
using Home_Project.Infrastuctur;
using System.Collections;

namespace Home_Project.Meneger
{
    public class BookMeneger : IMeneger<Book>, IEnumerable<Book>
    {
        public void Add(Book item)
        {
            throw new NotImplementedException();
        }

        public void Edit(Book item)
        {
            throw new NotImplementedException();
        }

        public void GetALl(Book item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Remove(Book item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
