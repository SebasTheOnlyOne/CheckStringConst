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
            var testString = "dsf�213��20   ��� �213��";
            Assert.AreEqual(Program.SearchAutoNum(testString), "");
            
        }

        [Test]
        public void Test2()
        {
            var testString1 = "dsf�213��20   ��� �213��154";
            Assert.AreEqual(Program.SearchAutoNum(testString1), "1: �213��154 ");
        }

        [Test]
        public void Test3()
        {
            var testString2 = "dsf�213��20   ��� �213��154 �213��23";
            Assert.AreEqual(Program.SearchAutoNum(testString2), "1: �213��154 2: �213��23 ");
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
        public void Test11()
        {
            var testString8 = @"http://example.com/";
            Assert.AreEqual(Program.ItIsHttp(testString8), @"��");
        }
        [Test]
        public void Test12()
        {
            var testString9 = "example.com";
            Assert.AreEqual(Program.ItIsHttp(testString9), @"���");
        }
        [Test]
        public void Test13()
        {
            var testString10 = "������.��";
            Assert.AreEqual(Program.ItIsHttp(testString10), @"���");
        }
        [Test]
        public void Test14()
        {
            var testString11 = @"https://example.com/";
            Assert.AreEqual(Program.ItIsHttp(testString11), @"��");
        }
    }
}