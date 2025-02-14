using SHA.Common.Utils;
using SHA.Domain.DTO;
using SHA.Domain.Entity;

namespace SHA.Services.IServices
{
    public interface IAuthService
    {
        Task<ResponseHelper> LoginAsyn(UserDTO userDTO);
        Task<ResponseHelper> IniciarSesionAsync(string nombreUsuario, string contrasena);
    }
}
