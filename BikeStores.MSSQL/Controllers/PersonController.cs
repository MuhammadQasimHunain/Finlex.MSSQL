using Finlex.MSSQL.Services;
using FinlexApp.DataLibrary.DataModel;
using Microsoft.AspNetCore.Mvc;

namespace Finlex.MSSQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        public IPersonService PersonService { get; set; }

        private readonly ILogger<PersonController> _logger;
        public PersonController(IPersonService personService)
        {
            this.PersonService = personService;
        }

        [Route("GetAllPersons")]
        [HttpGet]
        public IEnumerable<Person> GetAllPersons()
        {
            return PersonService.GetAllPersons();
        }

        [Route("GetAllPersonByEmail")]
        [HttpGet]
        public Person GetAllPersonByEmail(string email)
        {
            return PersonService.GetAllPersonByEmail(email);
        }


    }
}
