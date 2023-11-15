using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationExample1.Code.Controllers
{
    [Authorize]
    public class ControllerAuthorizeRequired : Controller
    {
       
    }
}
