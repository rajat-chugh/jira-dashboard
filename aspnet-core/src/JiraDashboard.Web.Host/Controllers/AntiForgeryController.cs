using Microsoft.AspNetCore.Antiforgery;
using JiraDashboard.Controllers;

namespace JiraDashboard.Web.Host.Controllers
{
    public class AntiForgeryController : JiraDashboardControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
