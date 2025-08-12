using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Lab
{
    public interface IDBConnection
    {
        void OpenConnection();

        void CloseConnection();
    }
}
