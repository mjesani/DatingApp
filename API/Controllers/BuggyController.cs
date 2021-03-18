using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly DataContext _dbContext;
        public BuggyController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("server-error")]
        public ActionResult<string> GetServerError()
        {
            var user = _dbContext.Users.Find(-1);
            return user.ToString();
        }

        [HttpGet("auth")]
        [Authorize]
        public ActionResult<string> GetAuthError()
        {
            var user = _dbContext.Users.Find(-1);
            return user.ToString();
        }

        [HttpGet("not-found")]
        public ActionResult<AppUser> GetNotFoundError()
        {
            var user = _dbContext.Users.Find(-1);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpGet("bad-request")]
        public ActionResult<AppUser> GetBadRequestError()
        {
            return BadRequest("Bad request");
        }

    }
}