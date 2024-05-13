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

    public partial class AddSubjectTeacher : Window
    {

        CuratorOrTeacher orTeacher = new CuratorOrTeacher();

        public AddSubjectTeacher()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ((INotifyCollectionChanged)teacherAndSubjectDataGrid.Items).CollectionChanged += ProductsListChanged;
            teacherAndSubjectDataGrid.ItemsSource = Helper.context.CuratorOrTeachers.ToList();
            teacherNameBox.ItemsSource = Helper.context.CuratorOrTeachers.ToList();
            subjectNameBox.ItemsSource = Helper.context.Subjects.ToList();



        }

        private void Roate(object sender, MouseButtonEventArgs e)
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                orTeacher = teacherNameBox.SelectedItem as CuratorOrTeacher;
                Subject subject = subjectNameBox.SelectedItem as Subject;
                orTeacher.Subjects.Add(subject);
                Helper.context.SaveChanges();
                Helper.ShowInformation("Сохранено!");



            }
            catch (Exception ex)
            {
                Helper.ShowError("Что-то пошло не так, проверьте корректность данных!");
            }
        }

        private void ClosingWindowButton_Click(object sender, RoutedEventArgs e) => this.Close();

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            teacherAndSubjectGrid.DataContext = new CuratorOrTeacher();
            teacherAndSubjectDataGrid.SelectedItem = null;
        }




        private void ProductsListChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            try
            {

                countTextBlock.Text = $"Показано {teacherAndSubjectDataGrid.Items.Count} из {Helper.context.CuratorOrTeachers.Count()} \n преподавателей";
            }
            catch (Exception ex)
            {
                Helper.ShowError("Что-то пошло не так, проверьте корректность данных!");
                countTextBlock.Text = string.Empty;
            }
        }

        public void Updating()
        {

            var list = Helper.context.CuratorOrTeachers.ToList();

            string search = filterTextBox.Text;

            if (!string.IsNullOrWhiteSpace(search))
                list = list.Where(a => a.FirstName.StartsWith(search)).ToList();

            teacherAndSubjectDataGrid.ItemsSource = list;
        }


        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void filterTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Updating();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
