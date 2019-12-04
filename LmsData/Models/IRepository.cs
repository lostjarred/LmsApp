using System;
using System.Collections.Generic;
using System.Text;

namespace LmsData.Models
{
    public interface IRepository
    {
        IEnumerable<Computers> GetAllComputers();
        Computers GetComputerById(int id);
        Computers Add(Computers model);

    }
}
