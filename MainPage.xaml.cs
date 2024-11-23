using System.Collections.ObjectModel;

namespace DeacRenataLab7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public ObservableCollection<Student> Students { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Students = new ObservableCollection<Student>
            {
                new Student { Name = "Ion Pop", Description = "Student la Informatica", ImagePath = "ion_pop.jpg" },
                new Student { Name = "Marta Ionescu", Description = "Studentă la Matematică", ImagePath = "marta_ionescu.jpg" },
                new Student { Name = "Andrei Alexandru", Description = "Student la Fizică", ImagePath = "andrei_alexandru.jpg" }
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
    public class Student
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = "Nicio descriere disponibilă";
        public string ImagePath { get; set; } = string.Empty;
    }
}

