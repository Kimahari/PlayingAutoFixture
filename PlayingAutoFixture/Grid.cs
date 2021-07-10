using System.Linq;

namespace PlayingAutoFixture {
    public class Grid {
        public Generation Refresh(Generation seed) {
            seed.First().Alive = false;
            return seed;
        }
    }
}
