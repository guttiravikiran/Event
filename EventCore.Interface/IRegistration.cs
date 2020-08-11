using EventCore.Model;
using System.Linq;

namespace EventCore.Interface
{
    public interface IRegistration
    {
        int AddUser(Registration entity);
        void AddAdmin(Registration entity);
        bool CheckUserNameExists(string Username);
        RegistrationViewModel Userinformation(int UserID);
        IQueryable<RegistrationViewModel> UserinformationList(string sortColumn, string sortColumnDir, string Search);

    }
}
