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
            string[] input = { "merhaba", "d�nya", "yaz�l�m" };
            
            //Act
            string result = encoder.Encode(input);

            //Assert
            string expected = "7#merhaba5#d�nya7#yaz�l�m";
            Assert.Equal(expected, result);
        }

        [Fact]  
        public void DecoderTests()
        {
            var decoder = new Decoder();
            string encoded = "7#merhaba5#d�nya7#yaz�l�m";
            string[] result = decoder.Decode(encoded);
            string[] expected = { "merhaba", "d�nya", "yaz�l�m" };
            Assert.Equal(expected, result);
        }
    }
}