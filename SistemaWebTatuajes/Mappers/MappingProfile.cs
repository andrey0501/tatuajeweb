using AutoMapper;
using SistemaWebTatuajes.Models;
using SistemaWebTatuajes.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LoginViewModel, Usuarios>();
            CreateMap<RecuperaContrasenaViewModel, Usuarios>();
            CreateMap<UsuarioViewModel, Usuarios>();
            CreateMap<ActualizarContrasenaViewModel, Usuarios>();
            CreateMap<EditUsuarioViewModel, Usuarios>();
            CreateMap<Usuarios, EditUsuarioViewModel>();
            CreateMap<PromocionesViewModel, Promociones>();
            CreateMap<EditPromocionViewModel, Promociones>();
            CreateMap<Promociones, EditPromocionViewModel>();
            CreateMap<Artistas, EditArtistaViewModel>();
            CreateMap<EditArtistaViewModel, Artistas>();
            CreateMap<CalificaViewModel, Califica>();
        }
    }
}
