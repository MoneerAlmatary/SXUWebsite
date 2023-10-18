using SXUWebsite.Data;
using SXUWebsite.Models;

namespace SXUWebsite.Repositories
{
    public class Broker : IBrokerages
    {
        private readonly ApplicationDbContext _context;
        
        public Broker (ApplicationDbContext context)
        {

            _context = context;
        }

        public void Add(Brokerage brokerage)
        {
            _context.Brokerages.Add(brokerage); 
        }

        public void Delete(Brokerage brokerage)
        {
            _context.Brokerages.Remove(brokerage);
        }

      

        public IEnumerable<Brokerage> GetAll()
        {
          return  _context.Brokerages.ToList();
        }

        public Brokerage GetById(int id)
        {
           return _context.Brokerages.Where(x=>x.ID == id).FirstOrDefault();

        }

        public IList<Brokerage> GetByName(string name)
        {
            return _context.Brokerages.Where(x => x.CompanyName.Contains(name)).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Brokerage brokerage)
        {
            _context.Brokerages.Update(brokerage);
        }
    }
}
