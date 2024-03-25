namespace FormulaOneAPI.Models
{
    public class LapTime
    {
        /// <summary>
        /// LapTimeId
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
        /// The lap which the time represents
        /// </summary>
        public int Lap { get; set; }

        /// <summary>
        /// Drivers position when lap time is set
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Lap time achieved
        /// </summary>
        public string Time { get; set; } = String.Empty;

        /// <summary>
        /// Milliseconds of lap time
        /// </summary>
        public int Milliseconds { get; set; }
    }
}
