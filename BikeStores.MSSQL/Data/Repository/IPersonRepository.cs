using FinlexApp.DataLibrary.DataModel;

namespace Finlex.MSSQL.Data.Repository
{
    public interface IPersonRepository
    {

        /// <summary>
        /// Get All Persons
        /// </summary>
        /// <returns></returns>
        List<Person> GetAllPersons();

        /// <summary>
        /// Get Person By Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Person GetAllPersonByEmail(string email);
    }
}
