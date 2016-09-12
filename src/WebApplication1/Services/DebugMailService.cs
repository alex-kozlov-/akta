using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class DebugMailService : IMailService
    {
        public void Send(string to, string from, string subject, string body)
        {
            Debug.WriteLine($"Sending email to: {to} from {from}. Subject {subject}. Message: {body}");
        }
    }
}
