using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SXUWebsite.Data;
using SXUWebsite.Models;

namespace SXUWebsite.Repositories
{
    public class StockRep : IStocks
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public StockRep(ApplicationDbContext context, IMapper mapper)
        {

            _context = context;
            this.mapper = mapper;
        }


        public void Add(Stocks Sto)
        {
            _context.Stocks.Add(Sto);
        }

        public void Delete(Stocks Sto)
        {
           _context.Stocks.Remove(Sto);
        }

        public IEnumerable<Stocks> GetAll()
        {
           return _context.Stocks.ToList();
        }

        public Stocks GetById(int id)
        {
            return _context.Stocks.Where(x => x.StockId == id).FirstOrDefault();
        }

        public Task GetById(int? id)
        {
            throw new NotImplementedException();
        }

       

        public IList<Stocks> GetByStatus(bool status)
        {
            return _context.Stocks.Where(x => x.StockStatus == true).ToList();

        }

        public IList<Stocks> GetByStatusfalse(bool status)
        {
            return _context.Stocks.Where(x => x.StockStatus == false).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Stocks Sto)
        {
            _context.Stocks.Update(Sto);    
        }
    }
}
