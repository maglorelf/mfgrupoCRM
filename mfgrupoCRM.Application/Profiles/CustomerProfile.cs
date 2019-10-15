using AutoMapper;
using mfgrupoCRM.Application.Dto;
using mfgrupoCRM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace mfgrupoCRM.Application.Profiles
{
 public   class CustomerProfile:Profile

    {
public CustomerProfile()
        {
            CreateMap<Customer, CustomerManageDto>();
        }
    }
}
