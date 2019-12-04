using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LmsData.Extensions;

namespace LmsData.Models
{
    // TODO: Impliment SQL Repository
    public class SqlRepository : IRepository
    {
        private LmsContext _context;

        public SqlRepository(LmsContext context)
        {
            _context = context;
        }


        public ComputerModel Add(ComputerModel model)
        {
            throw new NotImplementedException();
        }

        public MemberModel Add(MemberModel member)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MemberModel> GetActiveMembers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MentorModel> GetActiveMentors()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ComputerModel> GetAllComputers()
        {
            return _context.Computers;
        }

        public IEnumerable<MemberModel> GetAllMembers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MentorModel> GetAllMentors()
        {
            throw new NotImplementedException();
        }

        public ComputerModel GetComputerById(int id)
        {
            return _context.Computers.Where(x => x.Id == id).FirstOrDefault();
        }

        public MemberModel GetMemberById(int id)
        {
            throw new NotImplementedException();
        }

        public MemberModel GetMemberByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MemberModel> GetMembersByGoup(Enums.SessionType session)
        {
            throw new NotImplementedException();
        }
    }
}
