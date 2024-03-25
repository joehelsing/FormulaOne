namespace FormulaOneAPI.Models
{
    public class Season
    {
        /// <summary>
        /// SeasonId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Year of Season
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// URL of seasons wikipedia page
        /// </summary>
        public string URL { get; set; } = String.Empty;
    }
}
