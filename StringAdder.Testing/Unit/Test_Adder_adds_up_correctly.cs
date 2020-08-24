using Xunit;
using StringAdder.Models.StringAddition;

namespace StringAdder.Testing.Unit
{
    public class Test_Adder_adds_up_correctly
    {
        [Fact]
        public void Test_Adder_adds_up_correctly1()
        {
            var adder = getModel();
            Assert.Equal(5.9, adder.AddTogetherStringList("1.2,2.3,3.4"));
        }

        [Fact]
        public void Test_Adder_adds_up_correctly2()
        {
            var adder = getModel();
            Assert.False(adder.AddTogetherStringList("1.21,2.31,3.41") == 5.8);
        }

        [Fact]
        public void Test_Adder_adds_rejects_poor_string()
        {
            var adder = getModel();
            Assert.False(adder.CheckIsValidListOfNumbers("1.21,2.31,3.41"));
        }

        private Adder getModel()
        {
            return new Adder();
        }
    }
}
