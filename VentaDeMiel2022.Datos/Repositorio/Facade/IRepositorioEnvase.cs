using System.Collections.Generic;
using VentaDeMiel2022.Entidades.Entidades; 
using VentaDeMiel2022.Entidades.Enum; 

namespace VentaDeMiel2022.Datos.Repositorios.Facades
{
    public interface IRepositorioEnvases 
    {
        void Guardar(Envase envase);
        void Borrar(int envaseId); 
        Envase GetEnvasePorId(int id); 
        bool Existe(Envase envase); 
        bool EstaRelacionado(Envase envase); 
        List<Envase> GetLista(TipoEnvase tp, Orden orden); 
    }
}
