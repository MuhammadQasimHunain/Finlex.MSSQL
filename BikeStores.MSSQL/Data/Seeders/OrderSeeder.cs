using FinlexApp.DataLibrary;
using FinlexApp.DataLibrary.DataModel;

namespace Finlex.MSSQL.Data.Seeders
{
    public class OrderSeeder
    {
        private readonly DbOrderContext DbOrderContext;

        public OrderSeeder(DbOrderContext dbOrderContext)
        {
            this.DbOrderContext = dbOrderContext;
        }

        public void Seed()
        {
            if (!DbOrderContext.Persons.Any())
            {
                var persons = new List<Person>()
                {
                        new Person()
                        {
                            Name = "Person 1",
                            Email = "Person1@email.com"
                        },
                        new Person()
                        {
                            Name = "Person 2",
                            Email = "Person2@email.com"
                        }
                };

                DbOrderContext.Persons.AddRange(persons);
                DbOrderContext.SaveChanges();
            }

            if (!DbOrderContext.Orders.Any())
            {
                var orders = new List<Order>()
                {
                        new Order()
                        {
                            Price = 15,
                            Total = 10,
                            TotalPrice = 20,
                            ProductName = "Product Name 1",
                            OrderDate = DateTime.Now.AddDays(-1),
                            CreatedBy = "Person1@email.com"
                        },
                        new Order()
                        {
                            Price = 25,
                            Total = 20,
                            TotalPrice = 30,
                            ProductName = "Product Name 2",
                            OrderDate = DateTime.Now.AddDays(-2),
                            CreatedBy = "Person2@email.com"
                        }
                };

                DbOrderContext.Orders.AddRange(orders);
                DbOrderContext.SaveChanges();
            }

        }
    }
}
