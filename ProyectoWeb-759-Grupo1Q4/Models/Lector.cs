namespace ProyectoWeb_759_Grupo1Q4.Models;

public class Lector
{
    public string Id { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public string Country { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public string Role { get; set; } = Roles.Lector;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public static class Roles
    {
        public const string Bibliotecario = "Bibliotecario";
        public const string Lector = "Lector";

        public static bool EsValido(string rol) => rol == Bibliotecario || rol == Lector;
    }
}