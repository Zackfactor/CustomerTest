namespace CustomerTest.Data
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private readonly AppDbContext _appDbContext;
        private ICustomerRepository? _customerRepository;

        public RepositoryWrapper(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public ICustomerRepository Customer
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new EFCustomerRepository(_appDbContext);
                }

                return _customerRepository;
            }
        }

    }
}
