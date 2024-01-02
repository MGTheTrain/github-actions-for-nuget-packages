// <copyright file="IModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CommonLib.Domain.Models
{
    using System.ComponentModel.DataAnnotations;

    public interface IModel
    {
        /// <summary>
        /// Method for validating member attributes.
        /// </summary>
        /// <params></params>
        /// <returns>Returns void.</returns>
        IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
    }
}