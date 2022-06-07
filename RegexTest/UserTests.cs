using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UserTests
    {
        RegexValidation regexValidation; 
        [TestInitialize]
        public void InitValidationObj()
        {
            //Arrange -- initialise the object to compare/test
            regexValidation = new RegexValidation();
        }

        //Method to test firstname function in user registration project
        [TestMethod]
        public void FirstNameTest()
        {

            //Act -- basic logical construct for testing
            var FirstName= regexValidation.ValidateFirstName("Zeeshan");
            
            //Assert --  test comparison with the standard values
            Assert.IsTrue(FirstName);   

        }

        //Method to test lastname function in user registration project
        [TestMethod]
        public void LastNameTest()
        {

            //Act
            var LastName = regexValidation.ValidateLastName("Sarwar");

            //Assert
            Assert.IsTrue(LastName);

        }

        //Method to test Email function in user registration project
        [TestMethod]
        public void EmailTest()
        {

            //Act
            var Email = regexValidation.ValidateEmail("zeeshan.sarwar@fake.co.in");

            //Assert
            Assert.IsTrue(Email);

        }
        //ValidatePhone
        [TestMethod]
        public void PhoneNumberTest()
        {

            //Act
            var phoneNumber = regexValidation.ValidatePhone("91 2979243349");

            //Assert
            Assert.IsTrue(phoneNumber);

        }

        [TestMethod]
        public void PasswordTest()
        {

            //Act
            var password = regexValidation.ValidatePassword("sarwA1r@q");

            //Assert
            Assert.IsTrue(password);

        }


    }
}