using BusinessTier;
using BusinessTier.Repository;
using DataAccess.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Book_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IHrAccountRepository _bookService;

        public BooksController(IHrAccountRepository bookService)
        {
            _bookService = bookService;
        }
        // GET: api/<BooksController>
        [HttpGet]
        public ActionResult<List<HRAccount>> Get()
        {
            var list = _bookService.GetAllAccount();
            return Ok(list);
        }

        
    }
}
