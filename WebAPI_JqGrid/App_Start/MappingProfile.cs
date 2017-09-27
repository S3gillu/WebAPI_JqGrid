using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI_JqGrid.Dtos;
using WebAPI_JqGrid.Models;

namespace WebAPI_JqGrid.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ViewModel, ViewModelDto>();
            CreateMap<ViewModelDto, ViewModel>();
        }


    }
}