namespace FormulaOneAPI.Models
{
    public class Constructor
    {
        /// <summary>
        /// ConstructorId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Constructor reference string
        /// </summary>
        public string ConstructorRef { get; set; } = string.Empty;

        /// <summary>
        /// Official name of constructor
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Nationality of constructor
        /// </summary>
        public string Nationality { get; set; } = string.Empty;

        /// <summary>
        /// URL to constructors wikipedia page
        /// </summary>
        public string URL {  get; set; } = string.Empty;
    }
}
