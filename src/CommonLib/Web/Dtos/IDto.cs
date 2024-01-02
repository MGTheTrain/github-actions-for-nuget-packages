// <copyright file="IDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CommonLib.Web.Dtos
{
    using System.ComponentModel.DataAnnotations;

    public interface IDto
    {
        /// <summary>
        /// Method for validating member attributes.
        /// </summary>
        /// <params></params>
        /// <returns>Returns IEnumerable.<ValidationResult></returns>
        IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
    }
}