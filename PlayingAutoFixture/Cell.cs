namespace PlayingAutoFixture {
    public class Cell {
        public Cell(int x, int y, bool alive = false) {
            X = x;
            Y = y;
            Alive = alive;
        }

        public int X { get; }
        public int Y { get; }
        public bool Alive { get; set; }
    }
}
