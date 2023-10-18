using SXUWebsite.Models;
namespace SXUWebsite.Repositories
{
    public interface IContact
    {
        IEnumerable<ContactUs> GetAll();
        ContactUs GetById(int id);

        


        void Add(ContactUs contactUs);
        void Update(ContactUs contactUs);

        void Delete(ContactUs contactUs);
        void Save();



    }
}
