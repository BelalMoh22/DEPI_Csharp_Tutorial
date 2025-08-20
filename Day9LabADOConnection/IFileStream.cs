using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9LabADOConnection
{
    public interface IFileStream
    {
        void ReadFile(string filePath);

        void WriteFile(string fileName);
    }
}
