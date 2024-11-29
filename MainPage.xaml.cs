using System.Collections.ObjectModel;

namespace DeacRenataLab7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        // Proprietate pentru lista de studenți
        public ObservableCollection<Student> Students { get; set; }

        public MainPage()
        {
            InitializeComponent();

            // Inițializează lista de studenți
            Students = new ObservableCollection<Student>
            {
                new Student { Name = "Ion Popescu", Description = "Student la Informatica", ImagePath = "ion_popescu.jpg" },
                new Student { Name = "Maria Ionescu", Description = "Studentă la Matematică", ImagePath = "maria_ionescu.jpg" },
                new Student { Name = "Andrei Gheorghe", Description = "Student la Fizică", ImagePath = "andrei_gheorghe.jpg" }
            };

            // Setează BindingContext-ul pentru a lega datele cu interfața
            BindingContext = this;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

    // Definirea modelului Student
    public class Student
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
