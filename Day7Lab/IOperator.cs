using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Lab
{
    public interface IOperator // CRUD (CREATE , READ(ALL , By Id) , UPDATE , DELETE )
    {
        // When I inherit this interface must implement all the methods in interface
        void Create();

        void Delete();

        void Update();

        void GetAll();

        void GetById(int id);

        // From .Net8Core to up 
        public void GetByName(string name)
        {

        }
    }
}
