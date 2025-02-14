using SHA.Common.Utils;
using SHA.Domain.DTO;
using SHA.Domain.Entity;
using SHA.Repo;
using SHA.Services.IServices;

namespace SHA.Services.Service
{
    public class AuthService(AplicationDBContext dBContext, IConfiguration configuration) : IAuthService
    {
        private readonly IAuthService _authService;

        private readonly UsuarioRepo _suarioRepo = new(dBContext);

        public async Task<ResponseHelper> IniciarSesionAsync(string nombreUsuario, string contrasena)
        {
            var Usuario = await _suarioRepo.ObtenerPorNombreYPasswordAsync(nombreUsuario, contrasena);
            if (Usuario != null) {
                return new ResponseHelper { IsSuccess = true, Message = "Inicio de sesión exitoso", Data = Usuario };
            } return new ResponseHelper { IsSuccess = false, Message = "Fail" 
            };
        }

        public Task<ResponseHelper> LoginAsyn(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
