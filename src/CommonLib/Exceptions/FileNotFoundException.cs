// <copyright file="FileNotFoundException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CommonLib.Exceptions
{
    /// <summary>
    /// Represents an exception when a file is not found.
    /// </summary>
    public class FileNotFoundException : Exception
    {
        public FileNotFoundException(string message)
            : base(message)
        {
        }
    }
}