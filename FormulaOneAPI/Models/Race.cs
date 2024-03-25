namespace FormulaOneAPI.Models
{
    public class Race
    {
        /// <summary>
        /// RaceId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Year of race
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Round that race occured on
        /// </summary>
        public int Round { get; set; }

        /// <summary>
        /// CircuitId where race took place
        /// </summary>
        public int CircuitId { get; set; }

        /// <summary>
        /// Official name of race
        /// </summary>
        public string Name { get; set; } = String.Empty;

        /// <summary>
        /// Date that race occured on
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Start time of race
        /// </summary>
        public string Time { get; set; } = String.Empty;

        /// <summary>
        /// URL of race wikipedia page
        /// </summary>
        public string URL { get; set; } = String.Empty;

        /// <summary>
        /// Date of free practice one
        /// </summary>
        public DateTime FPOneDate { get; set; }

        /// <summary>
        /// Time of free practice one
        /// </summary>
        public string FPOneTime { get; set; } = String.Empty;

        /// <summary>
        /// Date of free practice two
        /// </summary>
        public DateTime FPTwoDate { get; set; }

        /// <summary>
        /// Time of free practice two
        /// </summary>
        public string FPTwoTime { get; set; } = String.Empty;

        /// <summary>
        /// Date of free practise three
        /// </summary>
        public DateTime FPThreeDate { get; set; }

        /// <summary>
        /// Time of free practice three
        /// </summary>
        public string FPThreeTime { get; set; } = String.Empty;

        /// <summary>
        /// Date of Qualifying
        /// </summary>
        public DateTime QualiDate { get; set; }

        /// <summary>
        /// Time of Qualifying
        /// </summary>
        public string QualiTime { get; set; } = String.Empty;

        /// <summary>
        /// Date of sprint race
        /// </summary>
        public DateTime SprintDate { get; set; }

        /// <summary>
        /// Time of sprint race
        /// </summary>
        public string SprintTime { get; set; } = String.Empty;
    }
}
