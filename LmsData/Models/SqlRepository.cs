using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LmsData.Models
{
    public class SqlRepository : IRepository
    {
        private LmsContext _context;

        public SqlRepository(LmsContext context)
        {
            _context = context;
        }


        public Computers Add(Computers model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Computers> GetAllComputers()
        {
            return _context.Computers;
        }

        public Computers GetComputerById(int id)
        {
            return _context.Computers.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
