namespace API.DTOs;

public class AdministradorLogado 
{
    public string Email { get; set; } = default!;
    public string Token { get; set; } = default!;
    public string Perfil { get; set; } = default!;
}