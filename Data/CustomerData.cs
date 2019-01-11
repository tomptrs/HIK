using BusinessFacade;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class CustomerData
    {
        private ArchitectDbContext _context;

        public CustomerData(ArchitectDbContext pContext)
        {
            _context = pContext;
        }

        public ICollection<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Save(Customer pCustomer)
        {
            //_context.SaveChanges(pCustomer);
        }
    }
}
