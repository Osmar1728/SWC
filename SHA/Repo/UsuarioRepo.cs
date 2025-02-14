using Microsoft.EntityFrameworkCore;
using SHA.Domain.Entity;

namespace SHA.Repo
{
    public class UsuarioRepo (AplicationDBContext dBContext)
    {
        public async Task AddAsync(Usuario usuario)
        {
            dBContext.Usuarios.Add(usuario);
            await dBContext.SaveChangesAsync();

        }

        public async Task<Usuario>ObtenerPorNombreYPasswordAsync(string User, string Password) 
        { 
            return await dBContext.Usuarios.FirstOrDefaultAsync(u => u.User == User && u.Password == Password);
        }
    }
}
