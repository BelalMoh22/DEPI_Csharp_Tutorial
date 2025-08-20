using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9LabADOConnection
{
    // Generic Interface
    public interface ICRUDOperation<T> where T: class  //CRUD
    {
        public void Insert(T item);

        public void Update(T item);

        public void Delete(int id);

        public T GetById(int id);

        public IEnumerable<T> GetAll();
    }
}
