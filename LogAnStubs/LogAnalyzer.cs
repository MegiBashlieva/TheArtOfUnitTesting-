using LogAnStubs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAnStubs
{
    class LogAnalyzer
    {
        IExtensionManager manager;

        public LogAnalyzer(IExtensionManager mng)
        {
            manager = mng;
        }
        public bool IsValidFileLogName(string fileName)
        {     
            return manager.isValid(fileName);
        }
    }
}
