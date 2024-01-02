// <copyright file="InvalidFileException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CommonLib.Exceptions
{
    /// <summary>
    /// Represents an exception when data is invalid.
    /// </summary>
    public class InvalidFileException : Exception
    {
        public InvalidFileException(string message)
            : base(message)
        {
        }
    }
}