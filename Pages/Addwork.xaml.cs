using System.Data.Entity;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;

namespace MainProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для Addwork.xaml
    /// </summary>
    public partial class Addwork : Window
    {
        private ApplicationContext db;
        public Task ToDoModel { get; set; }
        private BindingList<string> persons = new BindingList<string>();
        public Addwork(Task toDoModel)
        {
             
            db = new ApplicationContext();

            db.Persons.Load();
            BindingList<Person> people = db.Persons.Local.ToBindingList();

            InitializeComponent();

            ToDoModel = toDoModel;

            this.DataContext = ToDoModel;

            for (int i = 0; i < people.Count; i++)
            {
                string person = $"{people[i].Name} - {people[i].Position}";
                persons.Add(person);
            }
            comboPerson.ItemsSource = persons;
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void OK_Button(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
