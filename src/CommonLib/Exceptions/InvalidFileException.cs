namespace CommonLib.Exceptions
{
    /// <summary>
    /// Represents an exception when data is invalid.
    /// </summary>
    public class InvalidFileException : Exception
    {
        public InvalidFileException(string message) : base(message)
        {
        }
    }
}