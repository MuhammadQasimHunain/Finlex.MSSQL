using FinlexApp.DataLibrary;
using FinlexApp.DataLibrary.DataModel;

namespace Finlex.MSSQL.Data.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DbOrderContext DbOrderContext;

        public PersonRepository(DbOrderContext dbOrderContext)
        {
            this.DbOrderContext = dbOrderContext;
        }

        public Person GetAllPersonByEmail(string email)
        {
            return DbOrderContext.Persons.Where(d => d.Email.Equals(email))?.FirstOrDefault();
        }

        /// <summary>
        /// Get All Persons
        /// </summary>
        /// <returns></returns>
        public List<Person> GetAllPersons()
        {
            return DbOrderContext.Persons.ToList();
        }
    }
}
