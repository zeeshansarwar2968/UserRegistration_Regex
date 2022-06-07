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

        //Sad Test Cases(Test Cases which Fail The Entry validation)
        [TestMethod]
        public void GivenUserFistName_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                //Arrange -- declare a firstName string variable 
                string firstName = "zeeshan";

                //Act
                bool FirstName = regexValidation.ValidateFirstName(firstName);


            }
            catch (InvalidDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid First Name", e.Message);
                
            }
             
        }

        [TestMethod]
        public void GivenUserLastName_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                //Arrange -- declare a lastName string variable 
                string lastName = "sarwar";

                //Act
                bool LastName = regexValidation.ValidateFirstName(lastName);

            }
            catch (InvalidDetailException e)
            {

                //Assert
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
            
            
        }

        [TestMethod]
        public void GivenEmailId_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                //Arrange -- declare an email string variable 
                string email = "zeesahn.sarwar.com";

                //Act
                bool Email = regexValidation.ValidateEmail(email);

            }
            catch (InvalidDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid Email", e.Message);
            }
            
           
        }

        [TestMethod]
        public void GivenMobileNumber_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                //Arrange -- declare a number string variable 
                string number = "91 0863053941";

                //Act
                bool phoneNumber = regexValidation.ValidatePhone(number);

            }
            catch (InvalidDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid Phone Number", e.Message);
            }
            
        }

        [TestMethod]
        public void GivenPassword_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                //Arrange -- declare a password string variable 
                string password = "sarwa1r@q";

                //Act
                bool Password = regexValidation.ValidatePassword(password);

            }
            catch (InvalidDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid Password", e.Message);
            }
                      
        }

        //Data driven test attributes
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void ValidateEmailId_ShouldReturnTrue(string email)
        {
            Assert.IsTrue(regexValidation.ValidateEmail(email));
        }


    }
}