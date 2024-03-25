namespace FormulaOneAPI.Models
{
    public class Circuit
    {
        /// <summary>
        /// CircuitId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Circuit reference string
        /// </summary>
        public string CircuitRef { get; set; } = string.Empty;

        /// <summary>
        /// Official name of circuit
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Town/City of circuit
        /// </summary>
        public string Location { get; set; } = string.Empty;

        /// <summary>
        /// Country of circuit
        /// </summary>
        public string Country { get; set; } = string.Empty;

        /// <summary>
        /// Latitude of circuit
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Longitude of circuit
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Altitude of circuit in meters
        /// </summary>
        public double Altitude { get; set; }

        /// <summary>
        /// URL for circuits wikipedia page
        /// </summary>
        public string URL { get; set; } = string.Empty;
    }
}
