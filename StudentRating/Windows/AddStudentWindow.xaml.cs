using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Model;
using WpfApp1.Classes;
using System.Collections.Specialized;

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        Student student = new Student();

        bool isCheck = false;

        public AddStudentWindow()
        {
            InitializeComponent();
            DataContext = student;


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ((INotifyCollectionChanged)studentssDataGrid.Items).CollectionChanged += ProductsListChanged;
            groupBox.ItemsSource = Helper.context.Groups.ToList();
            studentssDataGrid.ItemsSource = Helper.context.Students.ToList();
            
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (!isCheck)
                    Helper.context.Students.Add(student);

                Helper.context.SaveChanges();
                Helper.ShowInformation("Сохранено!");

                isCheck = false;

                student = new Student();

                DataContext = student;

                studentsGrid.DataContext = student;

            }
            catch (Exception ex)
            {

                Helper.ShowError("Что-то пошло не так, проверьте корректность данных!");
            }
          

            


        }

        private void ClosingWindowButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            isCheck = true;
            Student selected = studentssDataGrid.SelectedItem as Student;
            studentsGrid.DataContext = selected;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var stud = studentssDataGrid.SelectedItem as Student;

            //if (login..Count > 0)
            //{
            //    Helper.ShowInformation("Преподавателя невозможно удалить");
            //    return;

            //}

            MessageBoxResult result = Helper.ShowQuestion("Вы действительно хотите удалить выбранного преподавателя?");

            if (result == MessageBoxResult.No)
                return;

            Helper.context.Students.Remove(stud);
            Helper.context.SaveChanges();
        }

        private void Rotate(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => this.Close();

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            studentsGrid.DataContext = new Student();
            studentssDataGrid.SelectedItem = null;
        }


        private void ProductsListChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            try
            {
               
                countTextBlock.Text = $"Показано {studentssDataGrid.Items.Count} из {Helper.context.Students.Count()} \n студентов";
            }
            catch (Exception ex)
            {
                Helper.ShowError(ex.Message.ToString());
                countTextBlock.Text = string.Empty;
            }
        }

        public void Updating()
        {

            var list = Helper.context.Students.ToList();

            string search = filterTextBox.Text;

            if (!string.IsNullOrWhiteSpace(search))
                list = list.Where(a => a.FirstName.StartsWith(search)).ToList();

            studentssDataGrid.ItemsSource = list;


        }

        private void filterTextBox_SelectionChanged(object sender, RoutedEventArgs e) => Updating();
    }
}
