namespace BackEnd.Services;
public interface ISecurityService
{
    Task GenerateJwt(object value);
    Task<string> GenerateSalt();
    Task<string> HashPassword(string password, string salt);
}