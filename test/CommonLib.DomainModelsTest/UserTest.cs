// <copyright file="UserTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CommonLib.DomainModelsTest
{
    using System.ComponentModel.DataAnnotations;
    using System.Reflection;
    using CommonLib.Domain.Models;

    public class UserTests
    {
        [Fact]
        public void Validate_UserProperties_ReturnsExpectedValidationResults()
        {
            // Arrange
            var user = new User(); // Create an instance of the User class

            // Set other properties for testing
            user.userName = "ValidUserName";
            user.userPassword = "StrongPassword123!";
            user.email = "test@example.com";
            user.userId = Guid.NewGuid();
            user.dateTimeCreated = DateTime.Now;
            user.dateTimeUpdated = DateTime.Now;

            // Additional null checks
            Assert.NotNull(user.userId);
            Assert.NotNull(user.dateTimeCreated);
            Assert.NotNull(user.dateTimeUpdated);
            Assert.NotNull(user.userName);
            Assert.NotNull(user.userPassword);
            Assert.NotNull(user.email);

            // Act
            var validationContext = new ValidationContext(user);
            var validationResults = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(user, validationContext, validationResults, true);

            // Assert
            Assert.True(isValid); // Ensure validation passes
            Assert.Empty(validationResults); // Ensure no validation errors
        }
    }
}