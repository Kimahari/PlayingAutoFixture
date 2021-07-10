namespace PlayingAutoFixture {

    public class Cell {

        #region Constructors

        public Cell(int x, int y, bool alive = false) {
            X = x;
            Y = y;
            Alive = alive;
        }

        #endregion Constructors

        #region Properties

        public bool Alive { get; set; }
        public int X { get; }
        public int Y { get; }

        #endregion Properties
    }
}