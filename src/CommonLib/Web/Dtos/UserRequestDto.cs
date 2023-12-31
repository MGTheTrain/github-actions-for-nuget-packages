using System;
using System.ComponentModel.DataAnnotations;

namespace CommonLib.Web.Dtos
{
    public class UserRequestDto: IDto
    {
        public string? userName { get; set; }
        public string? userPassword { get; set; }
        public string? email { get; set; }

                /// <summary>
        /// Method for validating member attributes
        /// </summary>
        /// <params></params>
        /// <returns>Returns IEnumerable<ValidationResult></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (userName == null || userName.Length > 50){
                yield return new ValidationResult($"{nameof(UserResponseDto)}.{nameof(userName)} can't be empty or exceed 50 characters");
            }
            if (userPassword == null || userPassword.Length < 10){
                yield return new ValidationResult($"{nameof(UserResponseDto)}.{nameof(userPassword)} can't be empty or less then 10 characters");
            }
            if (email == null){
                yield return new ValidationResult($"{nameof(UserResponseDto)}.{nameof(email)} can't be empty");
            }

            int specialCharCount = userPassword!.Count(c => !char.IsLetterOrDigit(c));
            int digitCount = userPassword!.Count(char.IsDigit);
            int upperCount = userPassword!.Count(char.IsUpper);
            int lowerCount = userPassword!.Count(char.IsLower);

            if (specialCharCount < 4 || digitCount < 2 || upperCount < 2 || lowerCount < 2)
            {
                yield return new ValidationResult($"{nameof(UserRequestDto)}.{nameof(userPassword)} does not meet complexity requirements.");
            }
            
            yield return ValidationResult.Success;
        }
    }
}
