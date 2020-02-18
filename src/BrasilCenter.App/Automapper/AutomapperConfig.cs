using AutoMapper;
using BrasilCenter.App.ViewModels;
using BrasilCenter.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrasilCenter.App.Automapper
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Livro, LivroViewModel>().ReverseMap(); //O reverse trata o mapeamento ida e volta.
        }
    }
}
