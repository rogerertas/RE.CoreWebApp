using Microsoft.Extensions.Configuration;
using Microsoft.Win32;
using System;
using System.Security.Principal;

namespace RE.CoreWebApp.Services
{
    public interface IGreeter
    {
        string Getmessage { get; }
    }
    public class Greeter : IGreeter
    {
        string UserName ()
        {   
            /*
            We need a wider scope without the necessity of a login for all identity types, not limited to windows.
            */

            var username = WindowsIdentity.GetCurrent().ToString();

            return username;
        }

        private string _message;
        

        public Greeter(IConfiguration configuration)
        {
            _message = configuration[@"Welcome" + UserName()];
        }

        public string Getmessage
        {
            get
            {
                return _message;
            }
        }
    }
}