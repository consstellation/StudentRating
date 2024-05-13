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
    /// Логика взаимодействия для AddGroupWindow.xaml
    /// </summary>
    public partial class AddGroupWindow : Window
    {
        Group group = new Group();

        bool isCheck = false;

        public AddGroupWindow()
        {
            InitializeComponent();
            DataContext = group;
        }

        private void ClosingWindowButton_Click(object sender, RoutedEventArgs e) => this.Close();

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var gro = groupsDataGrid.SelectedItem as Group;

            //if (login..Count > 0)
            //{
            //    Helper.ShowInformation("Преподавателя невозможно удалить");
            //    return;

            //}

            MessageBoxResult result = Helper.ShowQuestion("Вы действительно хотите удалить выбранного преподавателя?");

            if (result == MessageBoxResult.No)
                return;

            Helper.context.Groups.Remove(gro);
            Helper.context.SaveChanges();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            isCheck = true;
            Group selected = groupsDataGrid.SelectedItem as Group;
            groupGrid.DataContext = selected;

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

        public void Updating()
        {

            var list = Helper.context.Groups.ToList();

            string search = filterTextBox.Text;

            if (!string.IsNullOrWhiteSpace(search))
                list = list.Where(a => a.Name.StartsWith(search)).ToList();

            groupsDataGrid.ItemsSource = list;

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(!isCheck)
                Helper.context.Groups.Add(group);
                Helper.context.SaveChanges();
                Helper.ShowInformation("Сохранено!");

                isCheck = false;

                group = new Group();
                DataContext = group;
                groupGrid.DataContext = group;
            }
            catch (Exception ex)
            {
                Helper.ShowError("Что-то пошло не так, проверьте корректность данных!");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ((INotifyCollectionChanged)groupsDataGrid.Items).CollectionChanged += ProductsListChanged;
            teacherNameBox.ItemsSource = Helper.context.CuratorOrTeachers.ToList();
            groupsDataGrid.ItemsSource = Helper.context.Groups.ToList();
        }


        private void filterTextBox_SelectionChanged(object sender, RoutedEventArgs e) => Updating();


        
        private void Exit_Click(object sender, RoutedEventArgs e) => this.Close();

        private void ProductsListChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            try
            {
                countTextBlock.Text = $"Показано {groupsDataGrid.Items.Count} из {Helper.context.Groups.Count()} \n групп";
            }
            catch (Exception ex)
            {
                Helper.ShowError(ex.Message.ToString());
                countTextBlock.Text = string.Empty;
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            groupGrid.DataContext = new Group();
            groupsDataGrid.SelectedItem = null;
        }
    }
}
