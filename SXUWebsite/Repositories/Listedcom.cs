using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SXUWebsite.Data;
using SXUWebsite.Models;
using SXUWebsite.ViewModels;

namespace SXUWebsite.Repositories
{

    public class Listedcom : IListedcom
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public Listedcom(ApplicationDbContext context , IMapper mapper)
        {

            _context = context;
            this.mapper = mapper;
        }

     /*   public ListedCom Add(ListedCom lc )
        {
            _context.ListedComs.Add(lc);
            return lc;
        }*/

        public void AddTow(ListedCom lc , Stocks St )
        {

            _context.ListedComs.Add(lc);
            _context.Stocks.Add(St);
        }

        /*    public void AddTow(ListedCom lc, Stocks bb)
            {
                ListedCom com = new ListedCom()
                {

                    logoPath = uniqueName,
                    LiceincePath = uniquepdf,
                    CompanyName = listedCom.CompanyName,
                    CompanyCode = listedCom.CompanyCode,
                    CompanyAddress = listedCom.CompanyAddress,
                    Website = listedCom.Website,
                    Email = listedCom.Email,
                    Password = listedCom.Password,
                    ConfirmPassword = listedCom.ConfirmPassword,

                };
                Stocks mm = new();
                _context.ListedComs.Add(lc);
                _context.Stocks.Add(bb);

                throw new NotImplementedException();
            }*/

        public void Delete(ListedCom lc)
        {
            _context.ListedComs.Remove(lc);
        }

        public IEnumerable<ListedCom> GetAll()
        {
            return _context.ListedComs.Include(o=>o.Stocks).ToList();
        }

        public ListedCom GetById(int id)
        {
            return _context.ListedComs.Where(x => x.ID == id).FirstOrDefault();
        }

        public IList<ListedCom> GetByName(string name)
        {
            return _context.ListedComs.Where(x => x.CompanyName.Contains(name)).ToList();
        }

        public IList<ListedCom> GetByStatus(bool status)
        {
            return _context.ListedComs.Where(x => x.STATUS==true).ToList();
        }

      

        public IList<ListedCom> GetByStatusfalse(bool status)
        {
            return _context.ListedComs.Where(x => x.STATUS == false).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

      

        public void Update(ListedViewModel lc, int id)
        {
            var lcId = GetById(id);
            lcId.logoPath = lc.logoPath;
            lcId.LiceincePath = lc.LiceincePath;
            var applyDto = mapper.Map<ListedCom>(lc);
            _context.ListedComs.Update(applyDto);
        }

        
    }
}
