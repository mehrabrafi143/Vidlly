using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidlly.DTOs;
using Vidlly.Models;
using Vidlly.ViewModels;

namespace Vidlly.App_Start
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Customer, CustomersDto>();
            CreateMap<CustomersDto, Customer>();
            CreateMap<MembershipTypeDto, MembershipTypeDto>();
            CreateMap<CustomersDto, Customer>();
            CreateMap<Movie, MovieDTo>();
            CreateMap<MovieDTo, Movie>();
            CreateMap<Gener, GenerDTO>();
            CreateMap<GenerDTO, Gener>();
           
        }
    }
}