using NUnit.Framework;
using DEV3;

namespace TestForDEV3
{
    [TestFixture]
    public class UnitTest1
    {

        /// <summary>
        /// Transcoder body->converter tests
        /// </summary>
        [Test]
        public void TestConverterWrightAnswer()
        {
            string[] testArgs = { "167", "15" };
            string expected = "B2";

            BaseConverter testConverter = new BaseConverter();
            string result = testConverter.Convert(testArgs);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestConverterZeroNumNormalBase()
        {
            string[] testArgs = { "0", "19" };
            string expected = "0";

            BaseConverter testConverter = new BaseConverter();
            string result = testConverter.Convert(testArgs);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestConverterNormalNumNormalBase()
        {
            string[] testArgs = { "-0", "10",  };
            string expected = "0";

            BaseConverter testConverter = new BaseConverter();
            string result = testConverter.Convert(testArgs);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestConverterNormalNumOutOfRangeBase()
        {
            string[] testArgs = { "10", "24", };
            string expected = "Incorrect input" ;

            BaseConverter testConverter = new BaseConverter();
            string result = testConverter.Convert(testArgs);

            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// Transcoder body->CheckInput tests. Returns false if correct.
        /// </summary>
        [Test]
        public void TestInputCheckerNormalNumWrongBase()
        {
            string[] testArgs = { "10", "24", };
            bool expected = false;
            bool error = true;

            BaseConverter testConverter = new BaseConverter();
            bool result = testConverter.CheckInput(testArgs);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestInputCheckerWrongNumNormalBase()
        {
            string[] testArgs = { "1A94", "12", };
            bool expected = false;
            bool error = true;

            BaseConverter testConverter = new BaseConverter();
            bool result = testConverter.CheckInput(testArgs);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestInputCheckerNormalNumNormalBase()
        {
            string[] testArgs = { "1024", "15", };
            bool expected = false;
            bool error = true;

            BaseConverter testConverter = new BaseConverter();
            bool result = testConverter.CheckInput(testArgs);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestInputCheckerMinusNormalNumNormalBase()
        {
            string[] testArgs = { "-1024", "15", };
            bool expected = false;
            bool error = true;

            BaseConverter testConverter = new BaseConverter();
            bool result = testConverter.CheckInput(testArgs);

            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// Transcoder body->Reverse tests. Returns string.
        /// </summary>
        [Test]
        public void TestReversewrightanswer()
        {
            string testArgs = "123";
            string expected = "321";

            BaseConverter testConverter = new BaseConverter();
            string result = testConverter.Reverse(testArgs);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestReverseincorrectanswer()
        {
            string testArgs = "ABC";
            string expected = "ACB";

            BaseConverter testConverter = new BaseConverter();
            string result = testConverter.Reverse(testArgs);

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestReverseemptyString()
        {
            string testArgs = "";
            string expected = "" ;

            BaseConverter testConverter = new BaseConverter();
            string result = testConverter.Reverse(testArgs);

            Assert.AreEqual(expected, result);
        }
    }
}
