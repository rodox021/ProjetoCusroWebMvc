using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class CategoryAcessService
    {
        private readonly SalesWebMvcContext _context;

        public CategoryAcessService(SalesWebMvcContext context)
        {
            _context = context;
        }

       public async Task<List<CategoryAcess>> FindAllAsync()
        {
            return await _context.CategoryAcesses.OrderBy(x => x.Access).ToListAsync();
        }
    }
}
