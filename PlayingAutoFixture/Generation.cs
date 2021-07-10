using System;
using System.Collections;
using System.Collections.Generic;

namespace PlayingAutoFixture {
    public class Generation :IEnumerable<Cell> {
        public Generation(params Cell[] cells) {
            Cells = cells; 
        }

        public IEnumerable<Cell> Cells { get; }

        public IEnumerator<Cell> GetEnumerator() {
            foreach(var cell in Cells) {
                yield return cell;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator(); 
        }
    }
}
