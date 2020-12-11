using System;
using Xunit;

namespace CSTNet.Tests
{
    public class MultilineTests
    {
        [Fact]
        public void MiltilineV1()
        {
            var four = 4;
            var expected = $"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce justo dui, rhoncus a pulvinar sit amet, fermentum vitae lorem. Maecenas nec nisi sit amet eros rutrum congue. In sagittis suscipit arcu, ac vestibulum nunc feugiat volutpat.{Environment.NewLine}{Environment.NewLine}Vivamus consequat velit dui, sit amet rhoncus dui malesuada a. Maecenas hendrerit commodo mi et scelerisque. Cras pharetra ultrices aliquam. Praesent ac efficitur magna, vitae scelerisque metus.";
            var actual = CSTHelper.CSTFile("v1.cst", four.ToString());
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MiltilineV2()
        {
            var expected = $"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc gravida nunc non justo pretium consectetur. Sed tempus libero ac ligula aliquam elementum. Duis vitae interdum leo. Sed semper nulla %1 a lectus dictum dictum.{Environment.NewLine}{Environment.NewLine}Quisque vehicula, nisi ut scelerisque sodales, nisi ipsum sodales ipsum, in rutrum tellus lacus sed nibh. Etiam mauris velit, elementum sed placerat et, elementum et tellus. Duis vitae elit fermentum, viverra lorem in, lobortis elit.";
            var actual = CSTHelper.CSTFile("v2.cst", "Multiline");
            Assert.Equal(expected, actual);
        }
    }
}
