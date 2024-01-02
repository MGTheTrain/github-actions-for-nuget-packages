// <copyright file="UserRequestDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CommonLib.Web.Dtos
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UserRequestDto : IDto
    {
        public string? UserName { get; set; }

        public string? UserPassword { get; set; }

        public string? Email { get; set; }

        /// <summary>
        /// Method for validating member attributes.
        /// </summary>
        /// <params></params>
        /// <returns>Returns IEnumerable.<ValidationResult></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.UserName == null || this.UserName.Length > 50)
            {
                yield return new ValidationResult($"{nameof(UserResponseDto)}.{nameof(this.UserName)} can't be empty or exceed 50 characters");
            }

            if (this.UserPassword == null || this.UserPassword.Length < 10)
            {
                yield return new ValidationResult($"{nameof(UserResponseDto)}.{nameof(this.UserPassword)} can't be empty or less then 10 characters");
            }

            if (this.Email == null)
            {
                yield return new ValidationResult($"{nameof(UserResponseDto)}.{nameof(this.Email)} can't be empty");
            }

            int specialCharCount = this.UserPassword!.Count(c => !char.IsLetterOrDigit(c));
            int digitCount = this.UserPassword!.Count(char.IsDigit);
            int upperCount = this.UserPassword!.Count(char.IsUpper);
            int lowerCount = this.UserPassword!.Count(char.IsLower);

            if (specialCharCount < 4 || digitCount < 2 || upperCount < 2 || lowerCount < 2)
            {
                yield return new ValidationResult($"{nameof(UserRequestDto)}.{nameof(this.UserPassword)} does not meet complexity requirements.");
            }

            yield return ValidationResult.Success;
        }
    }
}
