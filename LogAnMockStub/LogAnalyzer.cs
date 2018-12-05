using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAnMockStub
{
    public class LogAnalyzer
    {

        public LogAnalyzer(IWebServices service, IEmail email)
        {
            Services = service;
            Email = email;
        }

        public IWebServices Services
        {
            get;
            set;
        }

        public IEmail Email { get; set; }

        public void Analyze(string fileName)
        {
            if (fileName.Length < 8 )
            {
                try
                {
                    Services.LogError("File  name too short:"+fileName);
                }
                catch(Exception e)
                {
                    Email.SendEmail("email@asd.com"," cant log",e.Message);
                }
            }
        }
    }
}
