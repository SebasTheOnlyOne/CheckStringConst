using NUnit.Framework;
using Homework3;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var testString = "dsfÀ213ÌÂ20   ûâä À213ÌÂ";
            Assert.AreEqual(Program.SearchAutoNum(testString), "");
            
        }

        [Test]
        public void Test2()
        {
            var testString1 = "dsfÀ213ÌÂ20   ûâä À213ÂÂ154";
            Assert.AreEqual(Program.SearchAutoNum(testString1), "1: À213ÂÂ154 ");
        }

        [Test]
        public void Test3()
        {
            var testString2 = "dsfÀ213ÂÂ20   ûâä À213ÂÂ154 À213ÂÂ23";
            Assert.AreEqual(Program.SearchAutoNum(testString2), "1: À213ÂÂ154 2: À213ÂÂ23 ");
        }
        [Test]
        public void Test4()
        {
            var testString3 = "142.23.0.255 ";
            Assert.AreEqual(Program.SearchIPv4(testString3), "1: 142.23.0.255 ");
        }
        [Test]
        public void Test5()
        {
            var testString4 = "123.2344.12.23 dfsf233.32.32.32 dsdf 123.12.23.13";
            Assert.AreEqual(Program.SearchIPv4(testString4), "1: 123.12.23.13 ");
        }
        [Test]
        public void Test6()
        {
            var testString4 = "123.2344.12.23 dfsf233.32.32.32 dsdf 123.12.23.13 124.23.0.255";
            Assert.AreEqual(Program.SearchIPv4(testString4), "1: 123.12.23.13 2: 124.23.0.255 ");
        }
        [Test]
        public void Test7()
        {
            var testString5 = "*this is italic*";
            Assert.AreEqual(Program.SwapToTeg(testString5), "<em>this is italic</em>");
        }
        [Test]
        public void Test8()
        {
            var testString6 = "**bold text (not italic)**";
            Assert.AreEqual(Program.SwapToTeg(testString6), "**bold text (not italic)**");
        }
        [Test]
        public void Test9()
        {
            var testString7 = "** **";
            Assert.AreEqual(Program.SwapToTeg(testString7), @"** **");
        }
        [Test]
        public void Test10()
        {
            var testString7 = "*f*";
            Assert.AreEqual(Program.SwapToTeg(testString7), @"<em>f</em>");
        }
        [Test]
        public void Test12()
        {
            var testString9 = "example.com";
            Assert.AreEqual(Program.ItIsHttp(testString9), @"Íåò");
        }
        [Test]
        public void Test13()
        {
            var testString10 = "êðåìëü.ðô";
            Assert.AreEqual(Program.ItIsHttp(testString10), @"Íåò");
        }
    }
}
