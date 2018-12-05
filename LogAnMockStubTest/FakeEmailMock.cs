using LogAnMockStub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAnMockStubTest
{
    class FakeEmailMock: IEmail
    {
        public string To;
        public string Subject;
        public string Body;

        public void SendEmail(string to, string sub, string body)
        {
            To = to;
            Subject = sub;
            Body = body;
        }
    }
}
