﻿using System.Collections.Generic;
using System.Linq;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;

namespace VentaDeMiel2022.Datos.Repositorio.Facade
{
    public interface IRepositorioCliente
    {
        void Guardar(Cliente cliente);

        List<Cliente> GetLista();

        void Borrar(int clienteId);

        Cliente GetClientePorId(int id);

        bool Existe(Cliente cliente);
        bool EstaRelacionado(Cliente cliente);
    }
}
