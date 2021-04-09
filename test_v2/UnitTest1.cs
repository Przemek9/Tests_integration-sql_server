using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConnectSQLServer;

namespace test_v2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student Jan = new Student(1, "Jan", "Kowalski");
            string expected = Jan.Imie;
            string actual = Student.Select_imie("test_aeh_students");
            Assert.AreEqual(expected, actual);
            Jan = null;

        }

        [TestMethod]
        public void TestMethod2()
        {
            Student Jan = new Student(1, "Jan", "Kowalski");
            string expected = Jan.Nazwisko;
            string actual = Student.Select_nazwisko("test_aeh_students");
            Assert.AreEqual(expected, actual);
            Jan = null;
        }

    }
}
