
namespace CommonLib.Exceptions
{
    /// <summary>
    /// Represents an exception when a user lacks necessary permissions.
    /// </summary>
    public class PermissionDeniedException : Exception
    {
        public PermissionDeniedException(string message) : base(message)
        {
        }
    }
}
