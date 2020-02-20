namespace LearningWPF.Data
{
	public class Classroom
	{
		public string Name { get; set; }
		public int NumberOfKids { get; set; }
		public int NumberOfKidsExpected { get; set; }
		public int NumberOfTeachers { get; set; }
		public int NumberOfTeachersExpected { get; set; }
		public int NumberOfKidsPerTeacherLegallyAllowed { get; set; }

		// See Number Conversion, Roland Backhouse, 2001: http://www.cs.nott.ac.uk/~psarb2/G51MPC/slides/NumberLogic.pdf
		public int NumberOfKidsPerTeacher => (NumberOfKids + NumberOfTeachers - 1) / NumberOfTeachers;

		public bool IsWithinRatio => (NumberOfKidsPerTeacher <= NumberOfKidsPerTeacherLegallyAllowed);
	}
}
