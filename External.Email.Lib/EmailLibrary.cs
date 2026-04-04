// This Email Library is external Services 

// implmented by different interface

public interface IEmail
{
    void SendEmail(string to , string subject, string body);
}
public class EmailLibrary : IEmail
{
    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"subject : {subject}");
        Console.WriteLine($"body : {body}");
        Console.WriteLine("Email Sent!");
    }
}