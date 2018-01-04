using System.Security;

namespace WindowBeginningEduGame
{
    /// <summary>
    /// An Interface for a class that can provide a secure password
    /// </summary>
    public interface IHavePassword
    {        
        SecureString SecurePassword { get; }
    }
}
