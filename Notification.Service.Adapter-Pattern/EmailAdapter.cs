using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Service.Adapter_Pattern
{
    public class EmailAdapter : INotificationService
    {
        private readonly EmailLibrary _emailService;
        public EmailAdapter(EmailLibrary emailService)
        {
            _emailService = emailService;
        }
        public void SendNotification(string from, string to, string subject, string message)
        {
            // Here we can add any additional logic if needed before sending the email
            _emailService.SendEmail(to, subject, message);
        }
    
    }
}
