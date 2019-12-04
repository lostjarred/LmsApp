using System;
using System.Collections.Generic;
using System.Text;
using static LmsData.Extensions.Enums;

namespace LmsData.Models
{
    public interface IRepository
    {
        IEnumerable<ComputerModel> GetAllComputers();
        ComputerModel GetComputerById(int id);
        ComputerModel Add(ComputerModel model);
        IEnumerable<MemberModel> GetAllMembers();
        IEnumerable<MemberModel> GetActiveMembers();
        MemberModel GetMemberById(int id);
        MemberModel GetMemberByName(string name);
        IEnumerable<MemberModel> GetMembersByGroup(SessionType session);
        IEnumerable<MentorModel> GetAllMentors();
        IEnumerable<MentorModel> GetActiveMentors();
        MemberModel Add(MemberModel member);

    }
}
