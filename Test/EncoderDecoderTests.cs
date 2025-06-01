using Endoce_Decode_Strings;

namespace Test
{
    public class EncoderDecoderTests
    {
        [Fact]
        public void EncoderTests()
        {
            //Arrange
            var encoder = new Encoder();
            string[] input = { "merhaba", "dünya", "yazýlým" };
            
            //Act
            string result = encoder.Encode(input);

            //Assert
            string expected = "7#merhaba5#dünya7#yazýlým";
            Assert.Equal(expected, result);
        }

        [Fact]  
        public void DecoderTests()
        {
            var decoder = new Decoder();
            string encoded = "7#merhaba5#dünya7#yazýlým";
            string[] result = decoder.Decode(encoded);
            string[] expected = { "merhaba", "dünya", "yazýlým" };
            Assert.Equal(expected, result);
        }
    }
}