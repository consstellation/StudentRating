using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SD = System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using  WpfApp1.Classes;
using WpfApp1.Model;
using exel = Microsoft.Office.Interop.Excel;
using WpfApp1.Windows;
using System.Data;
using System.Runtime.InteropServices;

namespace WpfApp1.Pages
{

    public partial class SuccessAccountingStudent : Page
    {

        public SuccessAccountingStudent()
        {
            InitializeComponent();
            lessonDateBox.SelectedDate = DateTime.Today;      
        }

        
        bool firstOpen = true;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            if(Helper.CheckAdmin)
            {
                lessonStudentsGrid.ItemsSource = Helper.context.LessonStudents.ToList();
            }
            else
            {

                deleteButton.Visibility = Visibility.Hidden;

                var listSubjects = new List<Subject> { new Subject { ID = -1, Name = "Все дисциплины" } };

                listSubjects.AddRange(Helper.curatorOrTeacher.Subjects.ToList());

                subjectBox.ItemsSource = listSubjects;

                subjectBox.SelectedIndex = 0;


                lessonStudentsGrid.ItemsSource = Helper.context.LessonStudents.Where(x => x.Lesson.ID_Teacher == Helper.curatorOrTeacher.ID).ToList();


                countPointBox.SelectedIndex = 0;
            }



            firstOpen = false;

        }

        private void OpenWindow(Window window) => window.ShowDialog();


        public void UpdateSubject()
        {
            try
            {

                if (firstOpen)
                    return;


                var list = Helper.context.LessonStudents.Where(x => x.Lesson.ID_Teacher == Helper.curatorOrTeacher.ID).ToList();

                string search = filterTextBox.Text;

                if (!string.IsNullOrWhiteSpace(search))
                    list = list.Where(a => a.Student.FirstName.StartsWith(search) || a.Student.LastName.StartsWith(search) || a.Student.MiddleName.StartsWith(search)).ToList();

                var typeSubject = subjectBox.SelectedItem as Subject;





                //if (student.ID != -1)
                //    list = list.Where(a => a.Student.FirstName == student.FirstName).ToList();


                DateTime lessonDate = lessonDateBox.SelectedDate.Value;

                if (useDate.IsChecked.Value)
                    list = list.Where(a => a.Lesson.DataLesson == lessonDate).ToList();




                if (typeSubject.ID != -1)
                    list = list.Where(a => a.Lesson.ID_Subject == typeSubject.ID).ToList();


                switch (countPointBox.SelectedIndex)
                {
                    case 1:
                        list = list.OrderBy(a => a.Point).ToList();
                        break;
                    case 2:
                        list = list.OrderByDescending(a => a.Point).ToList();
                        break;

                }


                lessonStudentsGrid.ItemsSource = list;

            }
            catch (Exception)
            {

                throw;
            }
        }



        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new SuccessAccoutingStudentWindow());
        }

        private void EditLesson_Click(object sender, RoutedEventArgs e)
        {
            LessonStudent selected = lessonStudentsGrid.SelectedItem as LessonStudent;

            OpenWindow(new SuccessAccoutingStudentWindow(){ DataContext = selected, LessonStudent = selected });
        
        }




        private void deleteLesson_Click(object sender, RoutedEventArgs e)
        {

        }



        private void filterTextBox_SelectionChanged(object sender, RoutedEventArgs e) => UpdateSubject();

        private void countPointBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => UpdateSubject();

        private void groupBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => UpdateSubject();

        private void lessonDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e) => UpdateSubject();

        private void useDate_Click(object sender, RoutedEventArgs e) => UpdateSubject();

        private void studentNameBox_SelectionChaged(object sender, SelectionChangedEventArgs e) => UpdateSubject();

        private void ClearButton_Click(object sender, RoutedEventArgs e) => lessonStudentsGrid.SelectedItem = null;

        private void otchetButton_Click(object sender, RoutedEventArgs e)
        {



        }
    }
}
