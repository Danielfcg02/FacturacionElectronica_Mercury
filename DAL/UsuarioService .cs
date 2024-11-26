using ENTITY;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using BLL;

public class UsuarioService
{
    private readonly UsuarioRepository _usuarioRepository;

    public UsuarioService()
    {
        _usuarioRepository = new UsuarioRepository(new OracleDbContext());
    }

    // Obtener todos los usuarios
    public async Task<List<Usuario>> GetAllUsuariosAsync()
    {
        return await _usuarioRepository.GetAllUsuarios();
    }

    // Obtener un usuario por ID
    public async Task<Usuario> GetUsuarioByCedulaAsync(string cedula)
    {
        return await _usuarioRepository.GetUsuarioByCedula(cedula);
    }

    public async Task<Usuario> GetUsuarioByUserNameAsync(string userName)
    {
        if (string.IsNullOrEmpty(userName))
            throw new ArgumentException("El nombre de usuario no puede estar vacío.");

        return await _usuarioRepository.GetUsuarioByUserName(userName);
    }

    // Agregar un usuario
    public async Task AddUsuario(Usuario usuario)
    {
        await _usuarioRepository.AddUsuario(usuario);
    }

    // Actualizar un usuario
    public async Task UpdateUsuarioAsync(Usuario usuario)
    {
        await _usuarioRepository.UpdateUsuario(usuario);
    }

    // Eliminar un usuario
    public async Task DeleteUsuarioAsync(string cedula)
    {
        await _usuarioRepository.DeleteUsuario(cedula);
    }
    
    public async Task<List<VendedorDto>> ObtenerTop10Vendedores(DateTime fechaInicio, DateTime fechaFin)
    {
        return await _usuarioRepository.GetTop10Vendedores(fechaInicio, fechaFin);
    }
}
