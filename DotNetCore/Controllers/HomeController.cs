using DotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace DotNetCore.Controllers
{
    [Route("api/welcome")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet] 

        public async Task<MessageBox> GetHelloMessage()
        {
            return new MessageBox()
            {
                Title = "Error",
                Message = "Hi"
            };
        }
    }
}
