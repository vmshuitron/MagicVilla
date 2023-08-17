using MagicVilla_API.Models.DTO;

namespace MagicVilla_API.Controllers.Datos
{
    public static class VillaStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>
        {
            new VillaDTO {Id=1,Nombre="Vista a la Pisina",Ocupantes=3,MetrosCuadrados=50 },
            new VillaDTO {Id=2,Nombre="Vista a la Playa",Ocupantes=4,MetrosCuadrados=80 }
        };
    }
}
