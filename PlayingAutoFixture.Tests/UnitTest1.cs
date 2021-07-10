using System;
using System.Collections.Generic;
using System.Linq;

using AutoFixture;
using AutoFixture.Dsl;

using FluentAssertions;

using Xunit;

namespace PlayingAutoFixture.Tests {
    public class When_calculating_a_generation {

        [Fact]
        public void It_should_return_a_generation_containing_cells() {
            var fixture = new Fixture();

            var seed = fixture.Create<Generation>();
            var grid = fixture.Create<Grid>();

            var nextGeneration = grid.Refresh(seed);

            nextGeneration.Should().NotBeEmpty();
        }

        [Fact]
        public void It_should_return_same_number_of_cells_a_generation_containing_cells() {
            var fixture = new Fixture();

            var seed = fixture.Create<Generation>(); 
            var grid = fixture.Create<Grid>();

            var nextGeneration = grid.Refresh(seed);

            nextGeneration.Should().HaveSameCount(seed);
        }

        [Fact]
        public void It_should_kill_a_cell_without_neighbors() {
            var fixture = new Fixture();
            fixture.Customize<Cell>(create=> create.With(c=> c.Alive, true));
            fixture.Customize(new SingleElementSequence<Cell>());

            var seed = fixture.Create<Generation>();
            var grid = fixture.Create<Grid>();

            var nextGeneration = grid.Refresh(seed);

            nextGeneration.ElementAt(0).Alive.Should().BeFalse();
        }
    }
}
