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
using WpfApp1.Classes;
using WpfApp1.Pages;
using WpfApp1.Model;
namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddClassWindow.xaml
    /// </summary>
    public partial class AddClassWindow : Window
    {

        public Lesson Lesson { get; set; } = new Lesson();

       // bool edit;

        public AddClassWindow()
        {
           
            InitializeComponent();
            //edit = editLesson;
            //if (_lesson != null)
            //    lesson = _lesson;    

            if(Lesson.ID==0)
                Lesson.ID_Teacher = Helper.curatorOrTeacher.ID;
  

        }

        /// <summary>
        /// подгрузка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            groupBox.ItemsSource = Helper.curatorOrTeacher.Groups.ToList();
            //subjectBox.ItemsSource = Helper.context.Subjects.Where(x => x.ID == Helper.curatorOrTeacher.ID).ToList();
            subjectBox.ItemsSource = Helper.curatorOrTeacher.Subjects.ToList();
            datePicker.SelectedDate = DateTime.Today;
            lessonGrid.DataContext = Lesson;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {


            try
            {  
                
                if(Lesson.ID == 0)
                {
                    Helper.context.Lessons.Add(Lesson);
                    Helper.context.SaveChanges(); 
                    Helper.ShowInformation("Добавлено");
                    
                }
                else
                {
                    Helper.context.Entry(Lesson).State = System.Data.Entity.EntityState.Modified;
                    Helper.context.SaveChanges();
                    Helper.ShowInformation("Изменено!");
                }
                



            }
            catch (Exception ex)
            {

                Helper.ShowError("Что-то пошло не так, проверьте корректность данных!");

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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
