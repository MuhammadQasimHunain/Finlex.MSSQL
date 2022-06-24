using FinlexApp.DataLibrary.DataModel;

namespace Finlex.MSSQL.Services
{
    public interface IPersonService
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
