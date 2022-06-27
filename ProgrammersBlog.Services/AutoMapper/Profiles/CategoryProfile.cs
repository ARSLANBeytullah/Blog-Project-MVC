using AutoMapper;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.AutoMapper.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile() //Burada Dto'ları normal sınıflara dönüştürüyoruz. Bunun tam tersini yapmakta mümkündür. Yani bir Categori sınıfını bir CategoryAddDto sınıfına dönüştürebiliriz.
        {
            CreateMap<CategoryAddDto, Category>().
                ForMember(dest => dest.CreatedDate,opt=>opt.MapFrom(x=>DateTime.Now));//Burada CategoryAddDto Category'e dönüştürülmüştür(Map edilmiştir).Bu mapleme işlemi yapılırken eğer bir CreateDate alanı görülürse bunu DateTime.Now yapacaktır.
            CreateMap<CategoryUpdateDto, Category>().
                ForMember(dest => dest.ModifiedDate,opt=>opt.MapFrom(x=>DateTime.Now));
        }
    }
}
