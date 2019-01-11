using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Data
{
    public class DataManager
    {
        private DbContext _context;

        public DataManager(DbContext pContext)
        {
            _context = pContext;
        }
            
    }
}
