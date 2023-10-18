using SXUWebsite.Models;
using SXUWebsite.ViewModels;

namespace SXUWebsite.Repositories
{
    public interface IListedcom
    {
        IEnumerable<ListedCom> GetAll();
        ListedCom GetById(int id);

        IList<ListedCom> GetByName(string name);
        IList<ListedCom> GetByStatus(bool status);
        IList<ListedCom> GetByStatusfalse(bool status);


        void AddTow(ListedCom lc , Stocks St );
      /*  ListedCom Add(ListedCom lc);*/
        void Update( ListedViewModel lc , int id);

        void Delete(ListedCom lc);
        void Save();



    }
}
