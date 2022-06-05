using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;


namespace MainProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для Database.xaml
    /// </summary>
    public partial class Database : Page
    {
        private ApplicationContext db;
        public Database()
        {
            InitializeComponent();
            db = new ApplicationContext();

            db.Persons.Load();

            this.DataContext = db.Persons.Local.ToBindingList();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            PersonWindow personWindow = new PersonWindow(new Person());
            if (personWindow.ShowDialog() == true)
            {
                Person person = personWindow.Person;
                db.Persons.Add(person);
                db.SaveChanges();
            }
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            if (PersonData.SelectedItem == null) return;
            Person person = PersonData.SelectedItem as Person;
            PersonWindow personWindow = new PersonWindow(new Person
            {
                Id = person.Id,
                Name = person.Name,
                SurName = person.SurName,
                Age = person.Age,
                Position = person.Position,
                Phonenumber = person.Phonenumber,
            });

            if (personWindow.ShowDialog() == true)
            {
                person = db.Persons.Find(personWindow.Person.Id);
                if (person != null)
                {
                    person.Name = personWindow.Person.Name;
                    person.SurName = personWindow.Person.SurName;
                    person.Age = personWindow.Person.Age;
                    person.Position = personWindow.Person.Position;
                    person.Phonenumber = personWindow.Person.Phonenumber;
                    db.Entry(person).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (PersonData.SelectedItem == null) return;
            Person person = PersonData.SelectedItem as Person;
            db.Persons.Remove(person);
            db.SaveChanges();
        }
    }
}
