using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Request_Template___Prototype.Pattern
{
    public class ApiRequest : IRequestPrototype
    {
        public string Url { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string Body { get; set; }

        public ApiRequest Clone()
        {
            return new ApiRequest
            {
                Url = this.Url,
                Body = this.Body,
                Headers = new Dictionary<string, string>(this.Headers) // deep copy
            };
        }

        public ApiRequest BaseRequest()
        {
            return new ApiRequest
            {
                Url = "https://api.example.com",
                Headers = new Dictionary<string, string>
                {
                    { "Content-Type", "application/json" },
                    { "Authorization", "Bearer YOUR_TOKEN" }
                },
                Body = "{}"
            };
        }
    }
}
