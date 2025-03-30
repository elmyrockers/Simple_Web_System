namespace MyApp.Models;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public string Created { get; }
    public string Modified { get; }
}