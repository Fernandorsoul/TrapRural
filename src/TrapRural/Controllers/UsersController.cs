using Microsoft.AspNetCore.Mvc;
using TrapRural.Models;
using TrapRural.Services;

namespace TrapRural.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public IActionResult GetAllUsuarios()
        {
            var usuarios = _usuarioService.GetAllUsuarios();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id)
        {
            var usuario = _usuarioService.GetUsuarioById(id);

            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult CreateUsuario([FromBody] Usuario usuario)
        {
            if (usuario == null)
                return BadRequest();

            var CreatedUsuario = _usuarioService.CreateUsuario(usuario);
            return CreatedAtAction(nameof(GetUsuarioById), new { id = CreatedUsuario.Id }, CreateUsuario);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUsuario(int id, [FromBody] Usuario usuario)
        {
            if (usuario == null || id != usuario.Id)
                return BadRequest();

            var updatedUsuario = _usuarioService.UpdateUsuario(id, usuario);

            if (updatedUsuario == null)
                return NotFound();

            return Ok(updatedUsuario);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            var deletedUsuario = _usuarioService.DeleteUsuario(id);

            if (deletedUsuario == null)
                return NotFound();

            return NoContent();
        }
    }
}