using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSalesWebMvc.Data;
using NSalesWebMvc.Models;

namespace NSalesWebMvc.Services
{
    public class SellerService
    {
        private readonly NSalesWebMvcContext _context;

        public SellerService(NSalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

    }


}
