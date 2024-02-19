using Application.Interfaces.Contacts;
using Domain.Models;

namespace Application.Implement.Contacts
{
    public class ContactsBehavior : IContactsBehavior
    {
        private readonly TelePhoneContext _phoneContext;
        public ContactsBehavior(TelePhoneContext phoneContext)
        {
            _phoneContext = phoneContext;
        }
        public List<Domain.Models.Contacts> GetAll()
        {
            return _phoneContext.Contacts.ToList();
        }
    }
}
