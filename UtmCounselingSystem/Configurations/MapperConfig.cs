using AutoMapper;
using UtmCounselingSystem.Data;
using UtmCounselingSystem.Models;

namespace UtmCounselingSystem.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AppointmentType, AppointmentTypeVM>().ReverseMap();
        }
    }
}
