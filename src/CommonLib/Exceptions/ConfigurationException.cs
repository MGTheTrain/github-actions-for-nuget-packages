// <copyright file="ConfigurationException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CommonLib.Exceptions
{
    /// <summary>
    /// Represents an exception for configuration-related issues.
    /// </summary>
    public class ConfigurationException : Exception
    {
        public ConfigurationException(string message)
            : base(message)
        {
        }
    }
}
