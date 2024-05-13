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
using WpfApp1.Model;

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для SuccessAccoutingStudentWindow.xaml
    /// </summary>
    public partial class SuccessAccoutingStudentWindow : Window
    {

        public LessonStudent LessonStudent { get; set; } = new LessonStudent();

        
        public SuccessAccoutingStudentWindow()
        {
            InitializeComponent();

            //if (_lessonStudent != null)
            //    lessonStudent = _lessonStudent;

            //DataContext = lessonStudent;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(LessonStudent.ID == 0)
                {
                    Helper.context.LessonStudents.Add(LessonStudent);
                    Helper.context.SaveChanges();
                    Helper.ShowInformation("Успешно добавлено");
                    return;
                }
                else
                {
                    Helper.context.Entry(LessonStudent).State = System.Data.Entity.EntityState.Modified;
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
            catch (Exception ex)
            {

                Helper.ShowError(ex.Message.ToString());
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            groupBox.ItemsSource = Helper.curatorOrTeacher.Groups.ToList();
            subjectBox.ItemsSource = Helper.curatorOrTeacher.Subjects.ToList();
            studentBox.ItemsSource = Helper.context.Students.ToList();


            lessonBox.ItemsSource = Helper.curatorOrTeacher.Lessons.ToList();
            lessonStudentGrid.DataContext = LessonStudent; 


        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private void groupBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    Group group = groupBox.SelectedItem as Group;

        //    var list = Helper.context.Students.Where(a => a.ID_group == group.ID).ToList();

        //    studentBox.ItemsSource = list;

        //}
    }
}
