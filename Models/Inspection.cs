namespace InspectionAPI.Models
{
    public class Inspection
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Status {  get; set; } = String.Empty;
        [StringLength(500)]
        public string Comments {  get; set; }
        public int InspectionTypeId { get; set; }
        public InspectionType? InspectionType { get; set; }

    }
}
