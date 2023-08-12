using IdentityJWT.Data;
using IdentityJWT.Helpers;
using IdentityJWT.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdentityJWT.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {
        private readonly DataContext _context;
        public TokenController(DataContext _context) => this._context = _context;

        [HttpPost]
        public ActionResult<string> GetToken()
        {
            User user = new User { CI = "1902839398", Role = "Admin", Email = "email@com.cu" };
            return Ok(TokenHelper.GenerateToken(user));
        }
    }

}
