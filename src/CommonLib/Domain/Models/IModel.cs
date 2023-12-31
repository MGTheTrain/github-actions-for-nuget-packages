using System.ComponentModel.DataAnnotations;

namespace CommonLib.Domain.Models
{
    public interface IModel
    {
        /// <summary>
        /// Method for validating member attributes
        /// </summary>
        /// <params></params>
        /// <returns>Returns void</returns>
        IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
    }
}