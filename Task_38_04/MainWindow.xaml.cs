using Microsoft.VisualBasic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_38_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        private Students _students = new();
        public MainWindow()
        {
            InitializeComponent();
            flourComboBox.SelectedIndex = 0;
            StudentsListListBox.ItemsSource = _students.StudentsList;
        }
        private void addStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validate(out string errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }
            Student student = new Student(
                nameTextBox.Text,
            surnameTextBox.Text,
            patronomicsTextBox.Text,
            groupTextBox.Text,
            birthdayDatePicker.SelectedDate.Value,
            (StudentFlour)flourComboBox.SelectedIndex);
            _students.AddStudent(student);
            StudentsListListBox.Items.Refresh();
            Clear();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _students.Load();
            StudentsListListBox.ItemsSource = _students.StudentsList;
        }
        private bool Validate(out string error)
        {
            error = "";
            try
            {
                DateTime birthday = Convert.ToDateTime(birthdayDatePicker.SelectedDate);
                if (birthday.Year < 1980 || birthday.Year > 2008)
                {
                    error += "Выбирите дату рождения от 1980 до 2008 года\n";
                }
            }
            catch
            {
                error += "Некорректный ввод даты рождения\n";
            }

            if (string.IsNullOrEmpty(surnameTextBox.Text))
            {
                error += "Поле фамилии пусто\n";
            }
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                error += "Поле имени пусто\n";
            }
            if (string.IsNullOrEmpty(patronomicsTextBox.Text))
            {
                error += "Поле отчества пусто\n";
            }
            if (string.IsNullOrEmpty(groupTextBox.Text))
            {
                error += "Поле группы пусто\n";
            }
            if (error.Length > 0)
            {
                return false;
            }
            return true;
        }
        private void Clear()
        {
            nameTextBox.Clear();
            surnameTextBox.Clear();
            patronomicsTextBox.Clear();
            birthdayDatePicker.SelectedDate = null;
            groupTextBox.Clear();

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            _students.Save();
        }
        private void deliteStudentMenuItemClick(object sender, RoutedEventArgs e)
        {
            var item = StudentsListListBox.SelectedItem;
            if (item != null && item is Student student)
            {
                _students.RemoveStudent(student);
                StudentsListListBox.Items.Refresh();
            }
        }
        private void showStudentMenuItemClick(object sender, RoutedEventArgs e)
        {
            ShowStudentInfo();
        }
        private void ShowStudentInfo()
        {
            var item = StudentsListListBox.SelectedItem;
            if (item != null && item is Student student)
            {
                MessageBox.Show($"{student.Surname} {student.Name} {student.Patronymic}\nГруппа - {student.Group} \nПол - {student.FlourOfStudent()}\nДата рождения - {student.Birthday:d}");
            }
        }
        private void StudentsListMouseDoubleClick(object sender, RoutedEventArgs e)
        {
            var item = StudentsListListBox.SelectedItem;
            if (item != null && item is Student student)
            {
                ShowStudentInfo();
            }
        }
    }


}



