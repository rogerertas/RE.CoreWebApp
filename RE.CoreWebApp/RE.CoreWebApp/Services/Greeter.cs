using Microsoft.Extensions.Configuration;

namespace RE.CoreWebApp.Services
{
    public interface IGreeter
    {
        string Getmessage();
    }
    public class Greeter : IGreeter
    {
        private string _message;

        public Greeter(IConfiguration configuration)
        {
            _message = configuration["message"];
        }
        public string Getmessage()
        {
            return _message;
        }
    }
}