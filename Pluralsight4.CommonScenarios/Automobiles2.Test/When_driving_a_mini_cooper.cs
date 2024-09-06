using Automobiles;

namespace Automobiles2.Test
{
    public class When_driving_a_mini_cooper
    {
        private MiniCooper _auto;

        public When_driving_a_mini_cooper()
        {
            _auto = new MiniCooper();
        }

        [Fact]
        public void It_can_start()
        {
            Assert.NotNull(_auto.Start());
        }

        [Fact]
        public void It_can_stop()
        {
            Assert.NotNull(_auto.Stop());
        }

        [Fact]
        public void It_has_the_correct_name()
        {
            Assert.Equal("Mini Cooper", _auto.Name);
        }
    }
}