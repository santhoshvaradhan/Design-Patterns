using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Request_Template___Prototype.Pattern
{
    public interface IRequestPrototype
    {
        ApiRequest Clone();
    }
}
