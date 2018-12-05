using LogAnStubs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAnStubs
{
    class FileExtensionManager: IExtensionManager
    {
        public bool isValid(string fileName)
        {
            return true;
        }
    }
}
