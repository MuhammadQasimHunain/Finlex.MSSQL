using Finlex.MSSQL.Data.Repository;
using FinlexApp.DataLibrary.DataModel;

namespace Finlex.MSSQL.Services
{
    public class PersonService : IPersonService
    {
        public IPersonRepository PersonRepository { get; set; }
        public PersonService(IPersonRepository personRepository)
        {
            this.PersonRepository = personRepository;
        }
        public Person GetAllPersonByEmail(string email)
        {
            return PersonRepository.GetAllPersonByEmail(email);
        }

        public List<Person> GetAllPersons()
        {
            return PersonRepository.GetAllPersons();
        }
    }
}
