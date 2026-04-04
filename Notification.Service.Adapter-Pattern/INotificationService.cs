using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Service.Adapter_Pattern
{
    public interface INotificationService
    {
        void SendNotification(string from,string to,string subject, string message);
    }
}
