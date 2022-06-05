using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MainProject
{
    public class Task : INotifyPropertyChanged
    {
        
        private bool _isDone;
        private string _text;
        private string _nameplusjob;


        public bool isDone
        {
            get { return _isDone; }
            set { _isDone = value;
                OnPropertyChanged("isDone");
            }
        }
        

        public string Text
        {
            get { return _text; }
            set { _text = value;
                OnPropertyChanged("Text");
            }
        }

        public string NamePlusJob
        {
            get { return _nameplusjob; }
            set { _nameplusjob = value;
                OnPropertyChanged("NamePlusJob");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
