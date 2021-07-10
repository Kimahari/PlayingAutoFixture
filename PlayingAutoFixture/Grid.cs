using System.Linq;

namespace PlayingAutoFixture {

    public class Grid {

        #region Methods

        public Generation Refresh(Generation seed) {
            seed.First().Alive = false;
            return seed;
        }

        #endregion Methods
    }
}