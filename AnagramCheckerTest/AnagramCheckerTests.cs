using AnagramChecker;

namespace AnagramCheckerTest
{
    public class AnagramCheckerTests
    {
        [Test]
        public void WordsAreAnagrams_ValidAnagrams_ReturnsTrue()
        {
            //Arrange
            var anagramChecker = new AnnagramChecker();

            //Act & Asseert
            Assert.True(anagramChecker.WordsAreAnagrams("evil", "vile"));
            Assert.True(anagramChecker.WordsAreAnagrams("cheater", "teacher"));
            Assert.True(anagramChecker.WordsAreAnagrams("cheater", "TEACHER"));
        }

        [Test]
        public void WordsAreAnagrams_NotAnagrams_ReturnsTrue()
        {
            //Arrange
            var anagramChecker = new AnnagramChecker();

            //Act & Asseert
            Assert.False(anagramChecker.WordsAreAnagrams("vale", "vile"));
            Assert.False(anagramChecker.WordsAreAnagrams("evil", "evil"));
        }

        [Test]
        public void WordsAreAnagrams_InvalidInput_ThrowsException()
        {
            //Arrange
            var anagramChecker = new AnnagramChecker();

            //Act & Asseert
            Assert.Throws<ArgumentException>(() => anagramChecker.WordsAreAnagrams(null, "vile"));
            Assert.Throws<ArgumentException>(() => anagramChecker.WordsAreAnagrams("", "vile"));
            Assert.Throws<ArgumentException>(() => anagramChecker.WordsAreAnagrams("dollar$", "vile"));
            Assert.Throws<ArgumentException>(() => anagramChecker.WordsAreAnagrams("number1fan", "vile"));
            Assert.Throws<ArgumentException>(() => anagramChecker.WordsAreAnagrams("contains a space", "vile"));
        }

        [Test]
        public void WordsAreAnagrams_InvalidInputWithSpaces_ThrowsException()
        {
            //Arrange
            var anagramChecker = new AnnagramChecker();

            //Act & Asseert
            Assert.Throws<ArgumentException>(() => anagramChecker.WordsAreAnagrams("real fun", "funeral"));
            Assert.Throws<ArgumentException>(() => anagramChecker.WordsAreAnagrams("forty five", "over fifty"));
        }
    }
}