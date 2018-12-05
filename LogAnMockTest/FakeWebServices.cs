using LogAnMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAnMockTest
{
    class FakeWebServices:IWebServices
    {
        public string lastError;

        public void LogError(string msg)
        {
            lastError = msg;
        }
    }
}
