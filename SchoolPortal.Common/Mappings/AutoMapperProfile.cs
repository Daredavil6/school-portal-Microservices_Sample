using AutoMapper;
using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models;
using SchoolPortal.Common.Models.dboSchema;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SchoolPortal.Common.Mappings
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<CountryMaster, CreateCountryDto>().ReverseMap();
			CreateMap<CountryMaster, UpdateCountryDto>().ReverseMap();
			CreateMap<CountryMaster, ViewCountryDto>().ReverseMap();

			CreateMap<StateMaster, CreateStateDto>().ReverseMap();
			CreateMap<StateMaster, UpdateStateDto>().ReverseMap();
			CreateMap<StateMaster, ViewStateDto>().ReverseMap();

			CreateMap<CityMaster, CreateCityDto>().ReverseMap();
			CreateMap<CityMaster, UpdateCityDto>().ReverseMap();
			CreateMap<CityMaster, ViewCityDto>().ReverseMap();

			CreateMap<UserDetail, CreateUserDetailDto>().ReverseMap();
			CreateMap<UserDetail, UpdateUserDetailDto>().ReverseMap();
			CreateMap<UserDetail, ViewUserDetailDto>().ReverseMap();
		}
	}
}
