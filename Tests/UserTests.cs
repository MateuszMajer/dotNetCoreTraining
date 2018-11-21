using System;
using dotNetCore.Models;
using NUnit.Framework;

namespace Testing
{
  //  [TestFixture]
    public class UserTests
    {
        [Test]
        public void changing_email_should_succeed()
        {
            //Arrange
            var user = new User("mateuszmajer1992@gmail.com", "secretmmmmmmmmmmmmmmmmmm");
            //Act
            user.SetEmail("mateuszmajer1992@gmail.com");
            //Assert
            Assert.AreSame(user.Email, "mateuszmajer1992@gmail.com");
        }

        [Test]
        public void providing_empty_password_should_fail()
        {
            //Arrange
            var user = new User("mateuszmajer1992@gmail.com", "secretmmmmmmmmmmmmmmmmmm");
            //Act
            var exeption = Assert.Throws<Exception>(() => user.SetPassword("short"));
            //Assert
            Assert.NotNull(exeption);
            Assert.IsTrue(exeption.Message.Equals("Entered password is too short."));
        }
    }
}