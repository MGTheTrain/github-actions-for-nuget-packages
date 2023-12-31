namespace CommonLib.Exceptions
{  
    /// <summary>
    /// Represents an exception when there is an issue with the database connection.
    /// </summary>
    public class DatabaseConnectionException : Exception
    {
        public DatabaseConnectionException(string message) : base(message)
        {
        }
    }
}
