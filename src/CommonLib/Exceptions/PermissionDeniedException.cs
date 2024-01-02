// <copyright file="PermissionDeniedException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CommonLib.Exceptions
{
    /// <summary>
    /// Represents an exception when a user lacks necessary permissions.
    /// </summary>
    public class PermissionDeniedException : Exception
    {
        public PermissionDeniedException(string message)
            : base(message)
        {
        }
    }
}
