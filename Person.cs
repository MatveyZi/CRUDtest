using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MainProject
{
    public class Person : INotifyPropertyChanged
    {
        private string _name;
        private string _surname;
        private int _age;
        private string _position;
        private string _number;
        public int Id { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string SurName
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged("SurName");
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }

        public string Position
        {
            get { return _position; }
            set
            {
                _position = value;
                OnPropertyChanged("Position");
            }
        }

        public string Phonenumber
        {
            get { return _number; }
            set
            {
                _number = value;
                OnPropertyChanged("Phonenumber");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
