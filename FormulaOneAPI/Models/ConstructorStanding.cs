namespace FormulaOneAPI.Models
{
    public class ConstructorStanding
    {
        /// <summary>
        /// ConstructorStandingId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id of race
        /// </summary>
        public int RaceId { get; set; }

        /// <summary>
        /// Id of constructor
        /// </summary>
        public int ConstructorId { get; set; }

        /// <summary>
        /// Accumulated points by constructor
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// Position of constructor in constructor rankings
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Textual representation of constructors ranking
        /// </summary>
        public string PositionText { get; set; } = string.Empty;

        /// <summary>
        /// Accumulated wins by constructor
        /// </summary>
        public int Wins { get; set; }
    }
}
