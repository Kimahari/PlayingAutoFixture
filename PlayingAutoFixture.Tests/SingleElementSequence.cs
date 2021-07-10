
using System.Collections;
using System.Collections.Generic;

using AutoFixture;

namespace PlayingAutoFixture.Tests {
    internal class SingleElementSequence<T> :ICustomization {
        public SingleElementSequence() {
        }

        public void Customize(IFixture fixture) {
            fixture.Register(() => fixture.CreateMany<T>(1));
        }
    }
}