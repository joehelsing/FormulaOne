namespace FormulaOneAPI.Models
{
    public class Qualifying
    {
        /// <summary>
        /// QualifyingId
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
        /// Driver Number
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Qualifying position
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Qualifying 1 time
        /// </summary>
        public string QualOne { get; set; } = String.Empty;

        /// <summary>
        /// Qualifying 2 time
        /// </summary>
        public string QualTwo { get; set; } = String.Empty;

        /// <summary>
        /// Qualifying 3 time
        /// </summary>
        public string QualThree { get; set; } = String.Empty;
    }
}
