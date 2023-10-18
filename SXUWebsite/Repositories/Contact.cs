using SXUWebsite.Data;
using SXUWebsite.Models;

namespace SXUWebsite.Repositories
{
    public class Contact : IContact
    {

        private readonly ApplicationDbContext _context;

        public Contact(ApplicationDbContext context)
        {

            _context = context;
        }
        public void Add(ContactUs contactUs)
        {
            _context.ContactUs.Add(contactUs);
        }
       
        public void Delete(ContactUs contactUs)
        {
            _context.ContactUs.Remove(contactUs);
        }

        public IEnumerable<ContactUs> GetAll()
        {
            return _context.ContactUs.ToList();
        }

        public ContactUs GetById(int id)
        {
            return _context.ContactUs.Where(x => x.ID == id).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(ContactUs contactUs)
        {
            _context.ContactUs.Update(contactUs);
        }
    }
}
