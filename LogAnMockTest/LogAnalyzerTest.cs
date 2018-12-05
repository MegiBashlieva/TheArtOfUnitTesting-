using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogAnMock;
using NUnit.Framework;
namespace LogAnMockTest
{
    [TestFixture]
    class LogAnalyzerTest
    {
        [Test]
        public void Analyze_TooShortFileName_CallsWebServices()
        {
            FakeWebServices fake = new FakeWebServices();
            LogAnalyzer analyzer = new LogAnalyzer(fake);
            string shortName = "asdas";
            analyzer.Analyze(shortName);

            StringAssert.Contains("file name too short: asdas",fake.lastError);

        }
    }
}
