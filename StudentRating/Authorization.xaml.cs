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

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {


        Login loginIdUSers = new Login();
        public Authorization()
        {
            InitializeComponent();
            DataContext = loginIdUSers;
        }

     
        

        private void Auth_Click(object sender, RoutedEventArgs e)
        {

            if (loginBox.Text == "admin" && passwordBox.Text == "admin")
            {
                Helper.CheckAdmin = true;

                //passwordBox.Text=
           
            }
            else
            {
                var idUser = Helper.context.Logins.Where(a => a.Login1 == loginIdUSers.Login1 && a.Password == loginIdUSers.Password).FirstOrDefault();

                if (idUser == null)
                {
                    Helper.ShowError("Такого пользователя нет");
                    return;
                }


                CuratorOrTeacher teacher = Helper.context.CuratorOrTeachers.Where(x => x.ID == idUser.CuratorOrTeacher.ID).FirstOrDefault();
                Helper.curatorOrTeacher = teacher;
            }

            new MainWindow().Show();
            this.Close();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (res == MessageBoxResult.No)
                return;
            else
                this.Close();
        }

        private void AboutProgramm_Click(object sender, RoutedEventArgs e)
        {
            Helper.ShowInformation("Программа пока не закончена, хы^^");
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
    }
}
