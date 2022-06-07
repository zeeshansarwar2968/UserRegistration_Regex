using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UserTests
    {
        //declaration of variable regexValidation of RegexValidation class
        RegexValidation regexValidation;
        
        [TestInitialize]
        public void InitValidationObj()
        {
            //Arrange -- initialise the object to compare/test
            regexValidation = new RegexValidation();
        }

        //Method to test firstname function in user registration project
        [TestMethod]
        public void FirstNameTest_ShouldReturnTrue()
        {
            //Arrange -- declare a firstName string variable 
            string firstName = "Zeeshan";

            //Act -- basic logical construct for testing
            var FirstName= regexValidation.ValidateFirstName(firstName);
            
            //Assert --  test comparison with the standard values
            Assert.IsTrue(FirstName);   

        }

        //Method to test lastname function in user registration project
        [TestMethod]
        public void LastNameTest_ShouldReturnTrue()
        {
            //Arrange -- declare a lastName string variable 
            string lastName = "Sarwar";

            //Act
            var LastName = regexValidation.ValidateLastName(lastName);

            //Assert
            Assert.IsTrue(LastName);

        }

        //Method to test Email function in user registration project
        [TestMethod]
        public void EmailTest_ShouldReturnTrue()
        {
            //Arrange -- declare an email string variable 
            string email = "zeeshan.sarwar@fake.co.in";
            
            //Act
            var Email = regexValidation.ValidateEmail(email);

            //Assert
            Assert.IsTrue(Email);

        }
        //ValidatePhone
        [TestMethod]
        public void PhoneNumberTest_ShouldReturnTrue()
        {
            //Arrange -- declare a number string variable 
            string number = "91 2979243349";

            //Act
            var phoneNumber = regexValidation.ValidatePhone(number);

            //Assert
            Assert.IsTrue(phoneNumber);

        }

        //Validate Password
        [TestMethod]
        public void PasswordTest_ShouldReturnTrue()
        {
            //Arrange -- declare a passW string variable 
            string passW = "sarwA1r@q";

            //Act
            var password = regexValidation.ValidatePassword(passW);

            //Assert
            Assert.IsTrue(password);

        }

        //Sad Test Cases(Test Cases Fail The Entry)
        [TestMethod]
        public void GivenUserFistName_ShouldReturnFalse()
        {
            //Arrange -- declare a firstName string variable 
            string firstName = "zeeshan";
            
            //Act
            bool FirstName = regexValidation.ValidateFirstName(firstName);
            
            //Assert
            Assert.IsFalse(FirstName);
        }

        [TestMethod]
        public void GivenUserLastName_ShouldReturnFalse()
        {
            //Arrange -- declare a lastName string variable 
            string lastName = "sarwar";
            
            //Act
            bool LastName = regexValidation.ValidateFirstName(lastName);
            
            //Assert
            Assert.IsFalse(LastName);
        }

        [TestMethod]
        public void GivenEmailId_ShouldReturnFalse()
        {
            //Arrange -- declare an email string variable 
            string email = "zeesahn.sarwar.com";
            
            //Act
            bool Email = regexValidation.ValidateEmail(email);
            
            //Assert
            Assert.IsFalse(Email);
        }

        [TestMethod]
        public void GivenMobileNumber_ShouldReturnFalse()
        {
            //Arrange -- declare a number string variable 
            string number = "91 0863053941";
            
            //Act
            bool phoneNumber = regexValidation.ValidatePhone(number);
            
            //Assert
            Assert.IsFalse(phoneNumber);
        }

        [TestMethod]
        public void GivenPassword_ShouldReturnFalse()
        {
            //Arrange -- declare a password string variable 
            string password = "sarwa1r@q";
            
            //Act
            bool Password = regexValidation.ValidatePassword(password);
            
            //Assert
            Assert.IsFalse(Password);
        }


    }
}