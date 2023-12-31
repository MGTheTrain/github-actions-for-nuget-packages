using System;
using System.ComponentModel.DataAnnotations;

namespace CommonLib.Web.Dtos
{
    public class UserResponseDto: IDto
    {
        public Guid? userId { get; set; }
        public string? userName { get; set; }
        public string? email { get; set; }
        public DateTime? dateTimeCreated { get; set; }
        public DateTime? dateTimeUpdated { get; set; }

        /// <summary>
        /// Method for validating member attributes
        /// </summary>
        /// <params></params>
        /// <returns>Returns IEnumerable<ValidationResult></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
