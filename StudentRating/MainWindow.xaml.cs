using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static WpfApp1.Classes.Helper;
using WpfApp1.Pages;
using WpfApp1.Model;
using WpfApp1.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
    
       
        public MainWindow()
        {
            InitializeComponent();


            try
            {
                frame = mainFrame;
                frame.Navigate(new MainPage());
            }
            catch (Exception ex)
            {

                throw;
            }
    
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
            if(!CheckAdmin)
            {
                subjectsPreopds.IsEnabled = false;
                prepods.IsEnabled = false;
                subjects.IsEnabled = false;
                gropus.IsEnabled = false;
                logins.IsEnabled = false;
                students.IsEnabled = false;

            }
        }


        



        /// <summary>
        /// добавление занятия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLesson_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// просмотр занятия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewLesson_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// обновление таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateTable_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Успеваемость учащихся
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentPerformance_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rotate(object sender, System.Windows.Input.MouseButtonEventArgs e)
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



        /// <summary>
        /// перезод на страницу успеваемости учащихся
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuccessAccountingStudentsRadioButton_Checked(object sender, RoutedEventArgs e)
        {

            if (SuccessAccountingStudentsRadioButton.IsChecked.Value)
                frame.Navigate(new SuccessAccountingStudent());

        }

        /// <summary>
        /// переход на главную страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Checked(object sender, RoutedEventArgs e)
        {
            if(MainRadioButton.IsChecked.Value)
                frame.Navigate(new MainPage());

        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            new Authorization().Show();
            Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void User_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Group_Click(object sender, RoutedEventArgs e)
        {
            new AddGroupWindow().Show();
        }

        private void Student_Click(object sender, RoutedEventArgs e)
        {
            new AddStudentWindow().Show();
        }

        private void Subject_Click(object sender, RoutedEventArgs e)
        {
            new AddSubjectWindow().Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new AddSubjectTeacher().Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Teachers_Click(object sender, RoutedEventArgs e)
        {
            new AddTeacherWindow().Show();
        }

        private void Logins_Click(object sender, RoutedEventArgs e)
        {
            new AddLoginWindow().Show();
        }

        private void DiagramsRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void otchetsStudentsRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void suppoertRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
