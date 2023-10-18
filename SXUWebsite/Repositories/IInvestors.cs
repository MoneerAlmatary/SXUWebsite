using SXUWebsite.Models;

namespace SXUWebsite.Repositories
{
    public interface IInvestors
    {
        IEnumerable<Investors> GetAll();
        Investors GetById(int id);

        IList<Investors> GetByName(string name);
        IList<Investors> GetByStatus(bool status);
        IList<Investors> GetByStatusfalse(bool status);


        void Add(Investors Inv);
        void Update(Investors Inv);

        void Delete(Investors Inv);
        void Save();
        Task GetById(int? id);
    }
}
