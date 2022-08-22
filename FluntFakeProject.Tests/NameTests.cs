using FluntFakeProject.Domain.ValueObjects;

namespace FluntFakeProject.Tests
{
    [TestClass]
    public class NameTests
    {
        [TestMethod]
        public void NameTestAllPropertiesLowerThanThree()
        {
            var name = new Name("fs", "fs", "fs");
            Assert.AreEqual(false, name.IsValid);
        }

        [TestMethod]
        public void NameTestAllPropertiesGreaterThanTwenty()
        {
            var name = new Name("123456789123456789123", "123456789123456789123", "123456789123456789123");
            Assert.AreEqual(false, name.IsValid);
        }

        [TestMethod]
        public void NameTestAllPropertiesIsEmpty()
        {
            var name = new Name("", "", "");
            Assert.AreEqual(false, name.IsValid);
        }

        [TestMethod]
        public void NameTestAllPropertiesIsInSecureValidationsNearLowerThanThree()
        {
            var name = new Name("abcs", "absc", "absc");
            Assert.AreEqual(true, name.IsValid);
        }

        [TestMethod]
        public void NameTestAllPropertiesIsInSecureValidationsNearGreaterThanTwenty()
        {
            var name = new Name("123456789123456789", "123456789123456789", "123456789123456789");
            Assert.AreEqual(true, name.IsValid);
        }

        [TestMethod]
        public void NameTestFirstPropertyIsNullOrEmpty()
        {
            var name = new Name("", "1234567891", "1234567891");
            Assert.AreEqual(false, name.IsValid);
        }

        [TestMethod]
        public void NameTestFirstPropertyIsLowerThanThree()
        {
            var name = new Name("xx", "1234567891", "1234567891");
            Assert.AreEqual(false, name.IsValid);
        }

        [TestMethod]
        public void NameTestFirstPropertyIsGreaterThanTwenty()
        {
            var name = new Name("XXxxXXxxXXXXxxXXxxXXX", "1234567891", "1234567891");
            Assert.AreEqual(false, name.IsValid);
        }

        [TestMethod]
        public void NameTestSecondPropertyIsNullOrEmpty()
        {
            var name = new Name("1234567891", "", "1234567891");
            Assert.AreEqual(false, name.IsValid);
        }

        [TestMethod]
        public void NameTestSecondPropertyIsLowerThanThree()
        {
            var name = new Name("1234567891", "xx", "1234567891");
            Assert.AreEqual(false, name.IsValid);
        }

        [TestMethod]
        public void NameTestSecondPropertyIsGreaterThanTwenty()
        {
            var name = new Name("1234567891", "XXxxXXxxXXXXxxXXxxXXX", "1234567891");
            Assert.AreEqual(false, name.IsValid);
        }

        [TestMethod]
        public void NameTestThirdPropertyIsNullOrEmpty()
        {
            var name = new Name("1234567891", "1234567891", "");
            Assert.AreEqual(false, name.IsValid);
        }

        [TestMethod]
        public void NameTestThirdPropertyIsLowerThanThree()
        {
            var name = new Name("1234567891", "1234567891", "xx");
            Assert.AreEqual(false, name.IsValid);
        }

        [TestMethod]
        public void NameTestThirdPropertyIsGreaterThanTwenty()
        {
            var name = new Name("1234567891", "1234567891", "XXxxXXxxXXXXxxXXxxXXX");
            Assert.AreEqual(false, name.IsValid);
        }

        [TestMethod]
        public void NameTestAllPropertiesVerifyAcceptingNumbers()
        {
            var name = new Name("1234567891", "1234567891", "1234567891");
            Assert.AreEqual(true, name.IsValid);
        }

        [TestMethod]
        public void NameTestAllPropertiesVerifyAcceptingOtherCharacter()
        {
            var name = new Name("*&435x$#@x", "*&435x$#@x", "*&435x$#@x");
            Assert.AreEqual(true, name.IsValid);
        }

        [TestMethod]
        public void NameTestAllPropertiesVerifyAcceptingWhiteSpaces()
        {
            var name = new Name("abcde abcde", "abcde abcde", "abcde abcde");
            Assert.AreEqual(true, name.IsValid);
        }

        [TestMethod]
        public void NameTestAllPropertiesVerifyAcceptingUpperCases()
        {
            var name = new Name("ABCDEABCDE", "ABCDEABCDE", "ABCDEABCDE");
            Assert.AreEqual(true, name.IsValid);
        }

        [TestMethod]
        public void NameTestAllPropertiesVerifyAcceptingLowerCases()
        {
            var name = new Name("abcdeabcde", "abcdeabcde", "abcdeabcde");
            Assert.AreEqual(true, name.IsValid);
        }
    }
}