using Xunit;
using DataStructures.Graphs;
using System.Linq;

namespace DataStructures.UnitTests
{
    [Trait("When creating a graph with 4 cities connected to each other", "")]
    public class GraphTests
    {
        private const string Dublin = "Dublin";
        private const string Galway = "Galway";
        private const string Cork = "Cork";
        private const string Limerick = "Limerick";

        private readonly Graph<string, int> graph;

        public GraphTests()
        {
            graph = new Graph<string, int> {
                {Dublin,    Galway,     50},
                {Dublin,    Cork,       30},
                {Dublin,    Limerick,   100},
                {Galway,    Cork,       20},
                {Galway,    Limerick,   120},
                {Cork,      Limerick,   15}
            };
        }

        [Theory]
        [InlineData(0, 50)]
        [InlineData(1, 30)]
        [InlineData(2, 100)]
        public void Neighbors_Have_ExpectedCost(int neighborIndex, int expectedCost)
        {
            var dublin = graph[0] as GraphNode<string, int>;
            var neighbor = dublin
                .Neighbors
                .Skip(neighborIndex)
                .First();

            Assert.Equal(expectedCost, neighbor.Cost);
        }

        [Fact]
        public void Count_ShouldBe_4()
        {
            Assert.Equal(4, graph.Count);
        }

        [Fact]
        public void ShouldContain_Dublin()
        {
            Assert.True(graph.Contains(Dublin));
        }

        [Fact]
        public void ShouldContain_Galway()
        {
            Assert.True(graph.Contains(Galway));
        }

        [Fact]
        public void ShouldContain_Cork()
        {
            Assert.True(graph.Contains(Cork));
        }

        [Fact]
        public void ShouldContain_Limerick()
        {
            Assert.True(graph.Contains(Limerick));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void AllNodes_ShouldHave_3Neighbors(int index)
        {
            Assert.Equal(3, graph[index].Neighbors.Count);
        }
    }
}
