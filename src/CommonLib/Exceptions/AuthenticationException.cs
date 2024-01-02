// <copyright file="AuthenticationException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CommonLib.Exceptions
{
    /// <summary>
    /// Represents an exception related to authentication failures.
    /// </summary>
    public class AuthenticationException : Exception
    {
        public AuthenticationException(string message)
            : base(message)
        {
        }
    }
}