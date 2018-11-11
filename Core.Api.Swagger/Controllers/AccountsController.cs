using System.Collections.Generic;
using System.Linq;
using Core.Api.Swagger.Data;
using Core.Api.Swagger.Data.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace Core.Api.Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        public static ApiContext _context { get; set; }

        public AccountsController(ApiContext context)
        {
            _context = context;
        }

        // GET api/accounts/getall
        [HttpGet("getall")]
        public ActionResult<IList<Account>> Get()
        {
            var accounts = _context.Accounts.ToList();
            return Ok(accounts);
        }

        // GET api/accounts/get/{id}
        [HttpGet("get/{id}")]
        public ActionResult<Account> Get(long id)
        {
            var account = _context.Accounts.Find(id);
            return Ok(account);
        }

        // POST api/accounts/add
        [HttpPost("add")]
        public void Add([FromBody] Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }
        
        // DELETE api/accounts/delete/{id}
        [HttpDelete("delete/{id}")]
        public void Delete(long id)
        {
            var account = _context.Accounts.Find(id);
            _context.Accounts.Remove(account);
            _context.SaveChanges();
        }
    }
}