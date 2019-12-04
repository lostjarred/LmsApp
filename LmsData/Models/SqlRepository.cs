using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LmsData.Extensions;
using Microsoft.Extensions.Logging;
using static LmsData.Extensions.Enums;

namespace LmsData.Models
{
    // TODO: Impliment SQL Repository
    public class SqlRepository : IRepository
    {
        private readonly ILogger _logger;
        private LmsContext _context;

        public SqlRepository(ILogger logger, LmsContext context)
        {
            _logger = logger;
            _context = context;
        }


        public ComputerModel Add(ComputerModel model)
        {
            throw new NotImplementedException();
        }

        public MemberModel Add(MemberModel member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();

            return member;
        }

        public IEnumerable<MemberModel> GetActiveMembers()
        {
            return _context.Members.Where(x => x.IsActive);
        }

        public IEnumerable<MentorModel> GetActiveMentors()
        {
            return _context.Mentors.Where(x => x.Status != MentorStatus.Discontinued);
        }

        public IEnumerable<ComputerModel> GetAllComputers()
        {
            return _context.Computers;
        }

        public IEnumerable<MemberModel> GetAllMembers()
        {
            return _context.Members;
        }

        public IEnumerable<MentorModel> GetAllMentors()
        {
            return _context.Mentors;
        }

        public ComputerModel GetComputerById(int id)
        {
            return _context.Computers.Where(x => x.Id == id).FirstOrDefault();
        }

        public MemberModel GetMemberById(int id)
        {
            // Load the member details from the database
            MemberModel output = _context.Members.Where(m => m.Id == id).FirstOrDefault<MemberModel>();

            // Include Expectations
            _context.Entry(output).Collection(o => o.Expectations).Load();

            // Include Known Isues
            _context.Entry(output).Collection(o => o.KnownIssues).Load();

            return output;
        }

        public MemberModel GetMemberByName(string name)
        {
            // TODO: Impliment GetMemberByName method
            throw new NotImplementedException();
        }

        public IEnumerable<MemberModel> GetMembersByGroup(Enums.SessionType session)
        {
            return _context.Members.Where(x => x.BookedSession == session);
        }
    }
}
