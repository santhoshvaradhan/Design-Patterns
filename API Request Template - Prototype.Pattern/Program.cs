namespace API_Request_Template___Prototype.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype Pattern");

            // Create a base request

            ApiRequest baseRequest = new ApiRequest().BaseRequest();

            var request1 = baseRequest.Clone();
            request1.Url = "https://api.example.com/data";
            request1.Body = "{\"query\": \"data\"}";

            var request2 = baseRequest.Clone();
            request2.Url = "https://api.example.com/info";
            request2.Body = "{\"query\": \"info\"}";

            Console.WriteLine("Request 1:");
            Console.WriteLine($"URL: {request1.Url}");

            Console.WriteLine("Request 2:");
            Console.WriteLine($"URL: {request2.Url}");
        }
    }
}
