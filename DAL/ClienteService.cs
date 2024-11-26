using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteService
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteService()
        {
            _clienteRepository = new ClienteRepository(new BLL.OracleDbContext());
        }

        // Obtener todos los clientes
        public async Task<List<Cliente>> GetAllClientesAsync()
        {
            return await _clienteRepository.GetAllClientesAsync();
        }

        // Obtener un cliente por cédula
        public async Task<Cliente> GetClienteByCedulaAsync(string cedula)
        {
            return await _clienteRepository.GetClienteByCedulaAsync(cedula);
        }

        // Agregar un cliente
        public async Task CrearClienteAsync(Cliente cliente)
        {
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));
            if (string.IsNullOrEmpty(cliente.Cedula)) throw new ArgumentException("La cédula no puede estar vacía.");
            if (string.IsNullOrEmpty(cliente.Nombre)) throw new ArgumentException("El nombre no puede estar vacío.");

            await _clienteRepository.AddClienteAsync(cliente);
        }


        // Actualizar un cliente
        public async Task UpdateClienteAsync(Cliente cliente)
        {
            await _clienteRepository.UpdateClienteAsync(cliente);
        }

        // Eliminar un cliente
        public async Task DeleteClienteAsync(string cedula)
        {
            if (string.IsNullOrEmpty(cedula)) throw new ArgumentException("La cédula no puede estar vacía.");

            var cliente = await _clienteRepository.GetClienteByCedulaAsync(cedula);
            if (cliente == null) throw new KeyNotFoundException("Cliente no encontrado.");

            await _clienteRepository.DeleteClienteAsync(cedula);
        }

        public async Task<List<ClienteTopDto>> GetTop10Clientes(DateTime fechaInicio, DateTime fechaFin)
        {
            return await _clienteRepository.GetTop10Clientes(fechaInicio, fechaFin);
        }

    }
}
