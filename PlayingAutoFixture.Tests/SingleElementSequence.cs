using AutoFixture;

namespace PlayingAutoFixture.Tests {

    internal class SingleElementSequence<T> :ICustomization {

        #region Constructors

        public SingleElementSequence() {
        }

        #endregion Constructors

        #region Methods

        public void Customize(IFixture fixture) {
            fixture.Register(() => fixture.CreateMany<T>(1));
        }

        #endregion Methods
    }
}