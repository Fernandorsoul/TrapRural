using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TrapRural.Models;

namespace TrapRural.Services
{
    public interface IUsuarioService
    {
        List<Usuario> GetAllUsuarios();

        Task<ActionResult<Usuario>> GetUsuarioById(int id);

        Task<ActionResult<Usuario>>CreateUsuario(Usuario usuario);

       Task<ActionResult<Usuario>> UpdateUsuario(int id, Usuario usuario);

       Task<ActionResult<Usuario>> DeleteUsuario(int id);
        
    }
}