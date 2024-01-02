// <copyright file="UserResponseDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CommonLib.Web.Dtos
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UserResponseDto : IDto
    {
        public Guid? UserId { get; set; }

        public string? UserName { get; set; }

        public string? Email { get; set; }

        public DateTime? DateTimeCreated { get; set; }

        public DateTime? DateTimeUpdated { get; set; }

        /// <summary>
        /// Method for validating member attributes.
        /// </summary>
        /// <params></params>
        /// <returns>Returns IEnumerable.<ValidationResult></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
