using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
using WpfApp1.Classes;
using WpfApp1.Model;
namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddTeacherWindow.xaml
    /// </summary>
    public partial class AddTeacherWindow : Window
    {

        CuratorOrTeacher curatorOrTeacher = new CuratorOrTeacher();

        public AddTeacherWindow()
        {
            InitializeComponent();
            DataContext = curatorOrTeacher;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Helper.context.CuratorOrTeachers.Add(curatorOrTeacher);
                Helper.context.SaveChanges();
                Helper.ShowInformation("Сохранено!");

            }
            catch (Exception ex)
            {

                Helper.ShowError("Что-то пошло не так, проверьте корректность данных!");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ((INotifyCollectionChanged)teachersGrid.Items).CollectionChanged += ProductsListChanged;
            teachersGrid.ItemsSource = Helper.context.CuratorOrTeachers.ToList();

        }

        private void ProductsListChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            try
            {
                countTextBlock.Text = $"Показано {teachersGrid.Items.Count} из {Helper.context.CuratorOrTeachers.Count()} \n преподавателей";
            }
            catch (Exception ex)
            {
                Helper.ShowError(ex.Message.ToString());
                countTextBlock.Text = string.Empty;
            }
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

        private void ClosingWindowButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (res == MessageBoxResult.No)
                return;
            else
                this.Close();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            CuratorOrTeacher selected = teachersGrid.SelectedItem as CuratorOrTeacher;
            ssss.DataContext = selected;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var teacher = teachersGrid.SelectedItem as CuratorOrTeacher;

            if (teacher.Lessons.Count > 0)
            {
                Helper.ShowInformation("Преподавателя невозможно удалить");
                return;

            }
            MessageBoxResult result = Helper.ShowQuestion("Вы действительно хотите удалить выбранного преподавателя?");

            if (result == MessageBoxResult.No)
                return;

            Helper.context.CuratorOrTeachers.Remove(teacher);
            Helper.context.SaveChanges();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ssss.DataContext = new CuratorOrTeacher();
            teachersGrid.SelectedItem = null;
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => this.Close();


        public void Updating()
        {

            var list = Helper.context.CuratorOrTeachers.ToList();

            string search = filterTextBox.Text;

            if (!string.IsNullOrWhiteSpace(search))
                list = list.Where(a => a.FirstName.StartsWith(search)).ToList();

            teachersGrid.ItemsSource = list;

        }

        private void filterTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Updating();
        }
    }
}
