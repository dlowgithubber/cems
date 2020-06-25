using CEMS.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Infrastructure.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
