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
    /// Логика взаимодействия для AddSubjectWindow.xaml
    /// </summary>
    public partial class AddSubjectWindow : Window
    {
        Subject subject = new Subject();
        bool isCheck = false;

        public AddSubjectWindow()
        {
            InitializeComponent();
            DataContext = subject;
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ((INotifyCollectionChanged)subjectsDataGrid.Items).CollectionChanged += ProductsListChanged;
            subjectsDataGrid.ItemsSource = Helper.context.Subjects.ToList();


        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (!isCheck)
                    Helper.context.Subjects.Add(subject);

                Helper.context.SaveChanges();
                Helper.ShowInformation("Сохранено!");

                isCheck = false;

                subject = new Subject();

                DataContext = subject;

                subjectssGrid.DataContext = subject;


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
            Subject selected = subjectsDataGrid.SelectedItem as Subject;
            subjectssGrid.DataContext = selected;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var sub = subjectsDataGrid.SelectedItem as Subject;

            //if (login..Count > 0)
            //{
            //    Helper.ShowInformation("Преподавателя невозможно удалить");
            //    return;

            //}

            MessageBoxResult result = Helper.ShowQuestion("Вы действительно хотите удалить выбранного преподавателя?");

            if (result == MessageBoxResult.No)
                return;

            Helper.context.Subjects.Remove(sub);
            Helper.context.SaveChanges();
        }

        private void ProductsListChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            try
            {
                countTextBlock.Text = $"Показано {subjectsDataGrid.Items.Count} из {Helper.context.CuratorOrTeachers.Count()} \n предметов";
            }
            catch (Exception ex)
            {
                Helper.ShowError(ex.Message.ToString());
                countTextBlock.Text = string.Empty;
            }
        }

        public void Updating()
        {

            var list = Helper.context.Subjects.ToList();

            string search = filterTextBox.Text;

            if (!string.IsNullOrWhiteSpace(search))
                list = list.Where(a => a.Name.StartsWith(search)).ToList();

            subjectsDataGrid.ItemsSource = list;


        }

        private void filterTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Updating();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            subjectssGrid.DataContext = new Subject();
            subjectsDataGrid.SelectedItem = null;
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => this.Close();
    }
}
