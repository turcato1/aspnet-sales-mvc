using NSalesWebMvc.Models;
using System.Linq;
using NSalesWebMvc.Data;
using System.Collections.Generic;

namespace NSalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly NSalesWebMvcContext _context;

        public DepartmentService(NSalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
