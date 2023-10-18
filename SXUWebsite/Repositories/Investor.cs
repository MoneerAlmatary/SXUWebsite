using AutoMapper;
using SXUWebsite.Data;
using SXUWebsite.Models;
using SXUWebsite.ViewModels;

namespace SXUWebsite.Repositories
{
    public class Investor : IInvestors
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public Investor(ApplicationDbContext context, IMapper mapper)
        {

            _context = context;
            this.mapper = mapper;
        }



        public void Add(Investors Inv)
        {
            _context.Investors.Add(Inv);
        }

        public void Delete(Investors Inv)
        {
           _context.Investors.Remove(Inv);  
        }

        public IEnumerable<Investors> GetAll()
        {
            return _context.Investors.ToList();
        }

        public Investors GetById(int id)
        {
            return _context.Investors.Where(x => x.InvId == id).FirstOrDefault();
        }

        public Task GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public IList<Investors> GetByName(string name)
        {
            return _context.Investors.Where(x => x.InvFirstName.Contains(name)).ToList();
        }

        public IList<Investors> GetByStatus(bool status)
        {
            return _context.Investors.Where(x => x.STATUS == true).ToList();
        }

        public IList<Investors> GetByStatusfalse(bool status)
        {
            return _context.Investors.Where(x => x.STATUS == false).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Investors Inv)
        {
            _context.Investors.Update(Inv);
        }
    }
}
