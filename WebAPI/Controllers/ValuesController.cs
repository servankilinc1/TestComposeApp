using Data.DAL;
using Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDal _dal;
        public ValuesController(IDal dal)
        {
            _dal = dal;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_dal.GetValue());
        }
    }
}
