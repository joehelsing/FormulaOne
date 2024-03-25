namespace FormulaOneAPI.Models
{
    public class PitStop
    {
        /// <summary>
        /// PitStopId
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
        /// Pit stop number during race
        /// </summary>
        public int Stop { get; set; }

        /// <summary>
        /// Lap that the pit stop occured on
        /// </summary>
        public int Lap { get; set; }

        /// <summary>
        /// Local time when pit stop occured
        /// </summary>
        public string Time { get; set; } = String.Empty;

        /// <summary>
        /// Duration of pit stop in seconds
        /// </summary>
        public decimal Duration { get; set; }

        /// <summary>
        /// Milliseconds of pit stop
        /// </summary>
        public int Milliseconds { get; set; }
    }
}
