namespace FormulaOneAPI.Models
{
    public class Status
    {
        /// <summary>
        /// StatusId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Driver status at end of race
        /// </summary>
        public string StatusText { get; set; } = String.Empty;
    }
}
