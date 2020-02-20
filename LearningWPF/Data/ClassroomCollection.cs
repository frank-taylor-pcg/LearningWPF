using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace LearningWPF.Data
{
	public class ClassroomCollection: INotifyPropertyChanged
	{
		public ObservableCollection<Classroom> Data { get; set; } = new ObservableCollection<Classroom>();

		public event PropertyChangedEventHandler PropertyChanged;

		public void Add(Classroom classroom)
		{
			int index = Data.Count;
			if (index == 0)
			{
				Data.Add(classroom);
				Data.Add(new Classroom()
				{
					Name = "Total",
					NumberOfKidsPerTeacherLegallyAllowed = 4
				});
			}
			else
			{
				Data.Insert(index - 1, classroom);
			}

			// Calculate all of the totals
			int iNumberOfKids = Data.Where(x => false == x.Name.Equals("Total")).Sum(x => x.NumberOfKids);
			int iNumberOfKidsExpected = Data.Where(x => false == x.Name.Equals("Total")).Sum(x => x.NumberOfKidsExpected);
			int iNumberOfTeachers = Data.Where(x => false == x.Name.Equals("Total")).Sum(x => x.NumberOfTeachers);
			int iNumberOfTeachersExpected = Data.Where(x => false == x.Name.Equals("Total")).Sum(x => x.NumberOfTeachersExpected);

			// This should now be the last element in the list
			Classroom total = Data[index];
			total.NumberOfKids = iNumberOfKids;
			total.NumberOfKidsExpected = iNumberOfKidsExpected;
			total.NumberOfTeachers = iNumberOfTeachers;
			total.NumberOfTeachersExpected = iNumberOfTeachersExpected;

			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Data)));
		}
	}
}
