using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrapRural.Data;
using TrapRural.Models;

namespace TrapRural.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly DataContext _context; 

        public UsuarioService(DataContext context)
        {
            context=_context;
        }

        public List<Usuario> GetAllUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public async Task<ActionResult<Usuario>> GetUsuarioById(int id)
        {
           return await _context.Usuarios.FirstOrDefaultAsync(x=> x.Id == id);
        }

        public async Task<ActionResult<Usuario>> UpdateUsuario(int id, Usuario usuario)
        {
            var UserbyId = await _context.Usuarios.FirstOrDefaultAsync(u=> u.Id == id);
            if(UserbyId != null)
            {
                UserbyId.Nome=usuario.Nome;
                UserbyId.Email=usuario.Email;
                UserbyId.Password=usuario.Password;
            }
             await _context.SaveChangesAsync();
            return UserbyId;
        }
        public async Task<ActionResult<Usuario>> CreateUsuario(Usuario usuario)
        {
            var NewUser = _context.Usuarios.OrderDescending();
            if (NewUser == null)
            {
                _context.Usuarios.Add(usuario);
                
            }
            
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task<ActionResult<Usuario>> DeleteUsuario(int id)
        {
           var UserById = _context.Usuarios.FirstOrDefaultAsync(r=> r.Id == id);
           if (UserById != null)
           {
             _context.Remove(id);
           }
           _context.SaveChangesAsync();
           return await UserById;
        }

        
    }
}