using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TestProject.Domain;
using TestProject.Persistance;
using TestProject.Repositories;

namespace XUnitTestProject1
{
    public class HashTest
    {
        [Fact(DisplayName = "Untampered_hash_matches_the_text")]
        public void Untampered_hash_matches_the_text()
        {
            // Arrange
            var message = "passw0rd";
            var salt = Salt.Create();
            var hash = PasswordHashing.Create(message, salt);

            // Act
            var match = PasswordHashing.Validate(message, salt, hash);

            // Assert
            Assert.True(match);
        }

        [Fact(DisplayName = "Tampered_hash_does_not_matche_the_text")]
        public void Tampered_hash_does_not_matche_the_text()
        {
            // Arrange
            var message = "passw0rd";
            var salt = Salt.Create();
            var hash = "blahblahblah";

            // Act
            var match = PasswordHashing.Validate(message, salt, hash);

            // Assert
            Assert.False(match);
        }

        [Fact(DisplayName = "Hash_of_two_different_messages_dont_match")]
        public void Hash_of_two_different_messages_dont_match()
        {
            // Arrange
            var message1 = "passw0rd";
            var message2 = "password";
            var salt = PasswordHashing.Create();

            // Act
            var hash1 = PasswordHashing.Create(message1, salt);
            var hash2 = PasswordHashing.Create(message2, salt);

            // Assert
            Assert.True(hash1 != hash2);
        }
    }
}
