using Microsoft.AspNetCore.Mvc;

namespace MyCoreApp.Entities.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string phone()
        {
            return "1+000-000-000";
        }

        public string Address()
        {
            return "ABC";
        }
    }
}
