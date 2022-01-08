using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZendCrestTest.UploadDocument.Data.Models;

namespace ZendCrestTest.UploadDocument.Data.DTOS.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDetail, UserDetailDTO>().ReverseMap();
            CreateMap<FileDetail, FileDetailDTO>().ReverseMap();
        }
    }
}
