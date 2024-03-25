namespace FormulaOneAPI.Models
{
    public class DriverStanding
    {
        /// <summary>
        /// DriverStandingId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// RaceId
        /// </summary>
        public int RaceId { get; set; }

        /// <summary>
        /// DriverId
        /// </summary>
        public int DriverId { get; set; }

        /// <summary>
        /// Drivers accumulated points
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// Drivers position in driver standings
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Textual representation of drivers position
        /// </summary>
        public string PositionText { get; set; } = String.Empty;

        /// <summary>
        /// Wins accumulated by driver
        /// </summary>
        public int Wins { get; set; }
    }
}
