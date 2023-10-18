using SXUWebsite.Models;

namespace SXUWebsite.Repositories
{
    public interface IStocks
    {

        IEnumerable<Stocks> GetAll();
        Stocks GetById(int id);

        IList<Stocks> GetByStatus(bool status);
        IList<Stocks> GetByStatusfalse(bool status);


        void Add(Stocks Inv);
        void Update(Stocks Inv);

        void Delete(Stocks Inv);
        void Save();
        Task GetById(int? id);

    }
}
