using ClassLibraryFor4567;

namespace TestProjectFor4567
{
    [TestClass]
    public class UnitTesFor4567
    {
        [TestMethod]
        public void GenerateCaptchaTest()
        {
            string first = "qwer";
            Class4567 cl = new Class4567();
            string second = cl.GenerateCaptcha(4);
            Assert.AreEqual(first.Length, second.Length);
        }
    }
}