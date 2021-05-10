using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly DataContext _context;
        public BuggyController(DataContext context)
        {
            _context = context;
        }
        [HttpGet("auth")]
        public ActionResult<string> GetSercet()
        {
            return "secret text";
        }

    }
}