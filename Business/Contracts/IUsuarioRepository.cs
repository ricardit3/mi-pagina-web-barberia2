﻿using PracticoSI1.Models;
using System.Threading.Tasks;

namespace PracticoSI1.Business.Contracts
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetNombreUsuario(string nombreusuario);
    }
}
