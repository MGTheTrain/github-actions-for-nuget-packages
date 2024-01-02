// <copyright file="UserRequestDtoTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CommonLib.WebDtosTest
{
    using System.ComponentModel.DataAnnotations;
    using System.Reflection;
    using CommonLib.Web.Dtos;

    public class UserRequestDtosTests
    {
        [Fact]
        public void Validate_UserRequestDtoProperties_ReturnsExpectedValidationResults()
        {
            // Arrange
            var userRequestDto = new UserRequestDto(); // Create an instance of the User class

            // Set other properties for testing
            userRequestDto.userName = "ValidUserName";
            userRequestDto.userPassword = "StrongPassword123!";
            userRequestDto.email = "test@example.com";

            // Additional null checks
            Assert.NotNull(userRequestDto.userName);
            Assert.NotNull(userRequestDto.userPassword);
            Assert.NotNull(userRequestDto.email);

            // Act
            var validationContext = new ValidationContext(userRequestDto);
            var validationResults = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(userRequestDto, validationContext, validationResults, true);

            // Assert
            Assert.True(isValid); // Ensure validation passes
            Assert.Empty(validationResults); // Ensure no validation errors
        }
    }
}