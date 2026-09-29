using kabenda;

namespace kabendatest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void BasicData()
        {
            string nonEncryptedText = "abc";
            int key = 3;
            string expectedEncryptedText = "def";

            Assert.AreEqual(expectedEncryptedText, Program.Encrypt(nonEncryptedText, key));
        }

        [TestMethod]
        public void LoopData()
        {
            string nonEncryptedText = "xyz";
            int key = 3;
            string expectedEncryptedText = "abc";

            Assert.AreEqual(expectedEncryptedText, Program.Encrypt(nonEncryptedText, key));
        }

        [TestMethod]
        public void DecryptData()
        {
            string nonEncryptedText = "def";
            int key = -3;
            string expectedEncryptedText = "abc";

            Assert.AreEqual(expectedEncryptedText, Program.Encrypt(nonEncryptedText, key));
        }

        [TestMethod]
        public void KeyBiggerThanAlphabet()
        {
            string nonEncryptedText = "abc";
            int key = 29;
            string expectedEncryptedText = "def";

            Assert.AreEqual(expectedEncryptedText, Program.Encrypt(nonEncryptedText, key));
        }

        [TestMethod]
        public void SpaceInData()
        {
            string nonEncryptedText = "ab cd";
            int key = 2;
            string expectedEncryptedText = "cd ef";

            Assert.AreEqual(expectedEncryptedText, Program.Encrypt(nonEncryptedText, key));
        }
    }
}
