using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Lab
//6)Generic type.
{
    internal class Operation<T> // CRUD (CREATE , READ (ALL , BY ID , UPDATE , DELETE))
    {
        public void Create(T item) { }

        public void Update(T item) { }

        public void Delete(int Id) { }

        public IEnumerable<T>  GetAll()
        {
            return null;
        }

        public T getById()
        {
            throw new NotImplementedException();
        }


    }
}
