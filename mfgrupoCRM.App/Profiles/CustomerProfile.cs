using AutoMapper;
using mfgrupoCRM.App.Dto;
using mfgrupoCRM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace mfgrupoCRM.App.Profiles
{
 public   class CustomerProfile:Profile

    {
public CustomerProfile()
        {
            CreateMap<Customer, CustomerManageDto>();
        }
    }
}
