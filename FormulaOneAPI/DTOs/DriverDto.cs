namespace FormulaOneAPI.DTOs
{
    public class DriverDto
    {
        /// <summary>
        /// DriverId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Number of driver
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Drivers 3 digit name code
        /// </summary>
        public string Code { get; set; } = String.Empty;

        /// <summary>
        /// Drivers forename
        /// </summary>
        public string Forename { get; set; } = String.Empty;

        /// <summary>
        /// Drivers surname
        /// </summary>
        public string Surname { get; set; } = String.Empty;

        /// <summary>
        /// Drivers Date of Birth
        /// </summary>
        public DateTime DOB { get; set; }

        /// <summary>
        /// Nationality of driver
        /// </summary>
        public string Nationality { get; set; } = String.Empty;

        /// <summary>
        /// URL of drivers wikipedia page
        /// </summary>
        public string URL { get; set; } = String.Empty;
    }
}
