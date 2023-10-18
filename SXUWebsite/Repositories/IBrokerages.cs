using SXUWebsite.Models;
namespace SXUWebsite.Repositories
{
    public interface IBrokerages
    {
        IEnumerable<Brokerage> GetAll();
        Brokerage GetById(int id);

        IList<Brokerage> GetByName(string name);

           
        void Add(Brokerage brokerage);
        void Update(Brokerage brokerage);
      
        void Delete(Brokerage brokerage);
       void Save ();

   


    }
}
