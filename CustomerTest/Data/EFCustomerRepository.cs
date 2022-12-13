using CustomerTest.Models;

namespace CustomerTest.Data
{
    public class EFCustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public EFCustomerRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
