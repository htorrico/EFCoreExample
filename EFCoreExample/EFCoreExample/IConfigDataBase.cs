using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreExample
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}
