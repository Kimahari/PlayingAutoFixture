using System.Collections;
using System.Collections.Generic;

namespace PlayingAutoFixture {

    public class Generation :IEnumerable<Cell> {

        #region Constructors

        public Generation(params Cell[] cells) {
            Cells = cells;
        }

        #endregion Constructors

        #region Properties

        public IEnumerable<Cell> Cells { get; }

        #endregion Properties

        #region Methods

        public IEnumerator<Cell> GetEnumerator() {
            foreach(var cell in Cells) {
                yield return cell;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        #endregion Methods
    }
}