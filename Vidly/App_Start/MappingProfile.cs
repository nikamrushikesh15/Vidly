using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using Vidly.DTOS;
using AutoMapper;

namespace Vidly.App_Start
{
    public class MappingProfile:Profile
    {

        public MappingProfile() {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();


        }
    }
}