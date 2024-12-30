using API.Dominio.Enteidades;
using API.DTOs;

namespace api.DTOs;

public interface IAdministradorInterface
{
    Administrador Incluir (AdministradorDTO administradorDTO);
    Administrador Login (LoginDTO loginDTO);
    List<Administrador> Todos ();
    Administrador PegarPorId (int id);
    void Excluir (int Id);
}