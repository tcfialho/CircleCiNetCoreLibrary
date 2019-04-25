using System;
using Xunit;

namespace DummyLibrary.Tests
{
    public class DummyTests
    {
        [Fact]
        public void ShouldCreateDummyObject()
        {
            var dummy = new Dummy();
            Assert.NotNull(dummy);
        }
    }
}
