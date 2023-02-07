using System.ComponentModel.DataAnnotations;

namespace Mission05_crofth.Models
{
    public class CalculatorModel
    {
        [Required]
        [Range(0, 100)]
        public float AssignmentGrade { get; set; }
        [Required]
        [Range(0, 100)]
        public float GroupProjectGrade { get; set; }
        [Required]
        [Range(0, 100)]
        public float QuizzesGrade { get; set; }
        [Required]
        [Range(0, 100)]
        public float MidtermExamGrade { get; set; }
        [Required]
        [Range(0, 100)]
        public float FinalExamGrade { get; set; }
        [Required]
        [Range(0, 100)]
        public float INTEXGrade { get; set; }

    }
}
