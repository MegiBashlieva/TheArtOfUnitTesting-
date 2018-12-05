using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAnMock
{
   public class LogAnalyzer
    {
        private IWebServices services;

        public LogAnalyzer(IWebServices ser)
        {
            this.services = ser;
        }

        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                services.LogError("file name too short: "+fileName);
            }
        }
    }
}
