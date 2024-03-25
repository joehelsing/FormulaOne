namespace FormulaOneAPI.Models
{
    public class SprintResult
    {
        /// <summary>
        /// SprintResultId
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
        /// ConstructorId
        /// </summary>
        public int ConstructorId { get; set; }

        /// <summary>
        /// Driver number
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Drivers position at start of sprint race
        /// </summary>
        public int Grid { get; set; }

        /// <summary>
        /// Final position of drivers that finished
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Textual representation of position
        /// </summary>
        public string PositionText { get; set; } = String.Empty;

        /// <summary>
        /// Final position of driver in race standings
        /// </summary>
        public int PositionOrder { get; set; }

        /// <summary>
        /// Points earned in sprint race
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// Laps completed in sprint race
        /// </summary>
        public int Laps { get; set; }

        /// <summary>
        /// Time completed in relation to winner
        /// </summary>
        public string Time { get; set; } = String.Empty;

        /// <summary>
        /// Milliseconds of time
        /// </summary>
        public int MilliSeconds { get; set; }

        /// <summary>
        /// Lap that driver achieved there fastest lap
        /// </summary>
        public int FastestLap { get; set; }

        /// <summary>
        /// Fastest lap time achieved during race
        /// </summary>
        public string FastestLapTime { get; set; } = String.Empty;

        /// <summary>
        /// Status at race end
        /// </summary>
        public int StatusId { get; set; }
    }
}
