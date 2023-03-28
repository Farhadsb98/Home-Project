using Home_Project.DataModel;
using Home_Project.Infrastuctur;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Project.Meneger
{


    public class AuthorMeneger : IMeneger<Author>,IEnumerable<Author>
    {
        Author[] data=new Author[0];
        public void Add(Author item)
        {
           int len = data.Length;
            Array.Resize(ref data, len+1);
            data[len] = item;
        }

        public void Edit(Author item)
        {
            throw new NotImplementedException();
        }

        public void GetALl(Author item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Author> GetEnumerator()
        {
            foreach (Author item in data)
            {
                yield return item;
            }
        }

        public void Remove(Author item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
