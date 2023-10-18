using AutoMapper;
using SXUWebsite.Models;
using SXUWebsite.ViewModels;
namespace SXUWebsite.Profiles
{
    public class ListedComProfile: Profile
    {
        public ListedComProfile()
        {
            CreateMap<Models.ListedCom,ViewModels.ListedViewModel>().ReverseMap();
        }
    }
}
