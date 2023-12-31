using System.ComponentModel.DataAnnotations;

namespace CommonLib.Web.Dtos
{
    public interface IDto
    {
        /// <summary>
        /// Method for validating member attributes
        /// </summary>
        /// <params></params>
        /// <returns>Returns IEnumerable<ValidationResult></returns>
        IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
    }
}