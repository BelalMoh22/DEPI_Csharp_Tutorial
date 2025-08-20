using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9LabADOConnection
{
    public class Product : ICRUDOperation<Product> , IFileStream
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product item)
        {
            throw new NotImplementedException();
        }

        public void ReadFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }

        public void WriteFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
