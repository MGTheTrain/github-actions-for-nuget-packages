// <copyright file="User.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CommonLib.Domain.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class User : IModel
    {
        public Guid? UserId { get; set; }

        public string? UserName { get; set; }

        public string? UserPassword { get; set; }

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
            if (this.UserId == null)
            {
                yield return new ValidationResult($"{nameof(User)}.{nameof(this.UserId)} can't be empty");
            }

            if (this.UserName == null || this.UserName.Length > 50)
            {
                yield return new ValidationResult($"{nameof(User)}.{nameof(this.UserName)} can't be empty or exceed 50 characters");
            }

            if (this.UserPassword == null || this.UserPassword.Length < 10)
            {
                yield return new ValidationResult($"{nameof(User)}.{nameof(this.UserPassword)} can't be empty or less then 10 characters");
            }

            if (this.Email == null)
            {
                yield return new ValidationResult($"{nameof(User)}.{nameof(this.Email)} can't be empty");
            }

            if (this.DateTimeCreated == null)
            {
                yield return new ValidationResult($"{nameof(User)}.{nameof(this.DateTimeCreated)} can't be empty");
            }

            if (this.DateTimeUpdated == null)
            {
                yield return new ValidationResult($"{nameof(User)}.{nameof(this.DateTimeUpdated)} can't be empty");
            }

            int specialCharCount = this.UserPassword!.Count(c => !char.IsLetterOrDigit(c));
            int digitCount = this.UserPassword!.Count(char.IsDigit);
            int upperCount = this.UserPassword!.Count(char.IsUpper);
            int lowerCount = this.UserPassword!.Count(char.IsLower);

            if (specialCharCount < 4 || digitCount < 2 || upperCount < 2 || lowerCount < 2)
            {
                yield return new ValidationResult($"{nameof(User)}.{nameof(this.UserPassword)} does not meet complexity requirements.");
            }

            yield return ValidationResult.Success;
        }
    }
}
