using AutoMapper;

namespace SXUWebsite.Profiles
{
    public class InvProfile : Profile
    {
        public InvProfile()
        {
            CreateMap<Models.Investors , ViewModels.InvViewModel>().ReverseMap();
        }

    }
}
