public class Users
{
    public int Id { get; set; }
    public string NombreCompleto { get; set; }
    public string Email { get; set; }
    public DateTime FechaCreacion { get; set; }
    public string PasswordHash { get; set; }
    public bool Activo { get; set; }
}