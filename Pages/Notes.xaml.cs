using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System;

namespace MainProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для Notes.xaml
    /// </summary>
    public partial class Notes : Page
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\tasks.json";
        private BindingList<Task> _tasks;
        private FileIOService _fileIOService;
        public Notes()
        {
            _fileIOService = new FileIOService(PATH);
            _tasks = _fileIOService.LoadData();
            this.DataContext = _tasks;

            InitializeComponent();
            _tasks.ListChanged += _tasks_ListChanged;

        }

        private void _tasks_ListChanged(object sender, ListChangedEventArgs e)
        {
            if(e.ListChangedType == ListChangedType.ItemChanged)
            {
                _fileIOService.SaveData(_tasks);
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Addwork addwork = new Addwork(new Task());
            if(addwork.ShowDialog() == true)
            {
                Task toDoModel = addwork.ToDoModel;
                _tasks.Add(toDoModel);
                _fileIOService.SaveData(_tasks);
            }    
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (dgTodoList.SelectedItem == null)
                return;
            Task task = dgTodoList.SelectedItem as Task;
            _tasks?.Remove(task);
            _fileIOService?.SaveData(_tasks);
        }
    }
}
