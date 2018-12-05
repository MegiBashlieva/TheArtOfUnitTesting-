using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LogAnMockStub;

namespace LogAnMockStubTest
{
    [TestFixture]
    class LogAnalyzerTest
    {

        [Test]
        public void Analyze_WebServicesThrows_EmailSend()
        {
            FakeWebService stubService = new FakeWebService();
            stubService.ToThrow = new Exception("fake exception");

            FakeEmailMock mockEmail = new FakeEmailMock();
            LogAnalyzer analyzer = new LogAnalyzer(stubService,mockEmail);
            string tooShortFileName = "abc.txt";
            analyzer.Analyze(tooShortFileName);

            StringAssert.Contains("email@asd.com",mockEmail.To);
            StringAssert.Contains("cant log",mockEmail.Subject);
            StringAssert.Contains("fake exception",mockEmail.Body);

        }
    }
}
