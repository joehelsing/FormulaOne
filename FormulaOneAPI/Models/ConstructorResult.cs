namespace FormulaOneAPI.Models
{
    public class ConstructorResult
    {
        /// <summary>
        /// ConstructorResultId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id of Race for the result
        /// </summary>
        public int RaceId { get; set; }

        /// <summary>
        /// Constructors Id
        /// </summary>
        public int ConstructorId { get; set; }

        /// <summary>
        /// Points scored by constructor
        /// </summary>
        public int Points { get; set; }
    }
}
