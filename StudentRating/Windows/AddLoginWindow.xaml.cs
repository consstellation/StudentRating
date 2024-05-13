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
    /// Логика взаимодействия для AddLoginWindow.xaml
    /// </summary>
    public partial class AddLoginWindow : Window
    {
        Login login = new Login();

        bool isCheck = false;
        public AddLoginWindow()
        {
            InitializeComponent();
            DataContext = login;
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ((INotifyCollectionChanged)loginsDataGrid.Items).CollectionChanged += ProductsListChanged;
            teacherNameBox.ItemsSource = Helper.context.CuratorOrTeachers.ToList();
            loginsDataGrid.ItemsSource = Helper.context.Logins.ToList();
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
            isCheck = true;
            Login selected = loginsDataGrid.SelectedItem as Login;
            gridLogin.DataContext = selected;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var login = loginsDataGrid.SelectedItem as Login;

            //if (login..Count > 0)
            //{
            //    Helper.ShowInformation("Преподавателя невозможно удалить");
            //    return;

            //}

            MessageBoxResult result = Helper.ShowQuestion("Вы действительно хотите удалить выбранного преподавателя?");

            if (result == MessageBoxResult.No)
                return;

            Helper.context.Logins.Remove(login);
            Helper.context.SaveChanges();
            Helper.ShowInformation("Удален!");
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
             

                if(!isCheck)
                Helper.context.Logins.Add(login);
                Helper.context.SaveChanges();
                Helper.ShowInformation("Сохранено!");

                isCheck = false;

                
                login = new Login();
                DataContext = login;
                gridLogin.DataContext = login;

            }
            catch (Exception ex)
            {

                Helper.ShowError("Что-то пошло не так, проверьте корректность данных!");
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            gridLogin.DataContext = new Login();
            loginsDataGrid.SelectedItem = null;
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => this.Close();


        private void ProductsListChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            try
            {
                countTextBlock.Text = $"Показано {loginsDataGrid.Items.Count} из {Helper.context.CuratorOrTeachers.Count()} \n преподавель";
            }
            catch (Exception ex)
            {
                Helper.ShowError(ex.Message.ToString());
                countTextBlock.Text = string.Empty;
            }
        }

        public void Updating()
        {

            var list = Helper.context.Logins.ToList();

            string search = filterTextBox.Text;

            if (!string.IsNullOrWhiteSpace(search))
                list = list.Where(a => a.CuratorOrTeacher.FirstName.StartsWith(search)).ToList();

            loginsDataGrid.ItemsSource = list;


        }
        private void filterTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Updating();

        }
    }
}
