namespace SantosJPITELECC1C.Models
{   public enum Rank
    {
        Instructor, Assistant Prof, Prof
    }
    public class Instructor
    {
        public int InstructorID { get; set; }
        public int InstructorName { get; set; }
        public int InstructorEmail { get; set; }
        public DateTime DateHired { get; set;}
        public Rank Rank { get; set; }

    }
}
