using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.UnitTests
{
    [TestFixture]
    class LogAnalyzerTests
    {


        [TestCase("dsffsd.FOO", false)]
        [TestCase("fsdfsd.SLF", true)]
        public void IsValidLogFileName_BadExtension_ReturnsFalse(string file, bool expected)
        {
            LogAnalyzer analyzer = MakeAnalyzer();
            bool result = analyzer.IsValidLogFileName(file);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsValidLogFileName_EmptyString_ThrowException()
        {
            LogAnalyzer analyzer = MakeAnalyzer();
            var ex = Assert.Catch<Exception>(()=> analyzer.IsValidLogFileName(""));
            StringAssert.Contains("filename has to be provided",ex.Message);
        }
        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
        }
       
    }
}
