//библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Model;
using WpfApp1.Classes;
using WpfApp1.Windows;


namespace WpfApp1.Pages
{

    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            lessonDateBox.SelectedDate = DateTime.Today;
        }

        bool firstOpen = true;


        /// <summary>
        /// loading data fot rhe page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (Helper.CheckAdmin)
            {
                clientsDataGrid.ItemsSource = Helper.context.Lessons.ToList();
            }
            else
            {
                deleteButton.Visibility = Visibility.Hidden;

                pointAndHoursBox.SelectedIndex = 0;

                var listSubjects = new List<Subject> { new Subject { ID = -1, Name = "Все дисциплины" } };

                listSubjects.AddRange(Helper.curatorOrTeacher.Subjects.ToList());

                subjectBox.ItemsSource = listSubjects;

                subjectBox.SelectedIndex = 0;


                var listGroups = new List<Group>() { new Group { ID = -1, Name = "Все группы" } };

                listGroups.AddRange(Helper.curatorOrTeacher.Groups.ToList());

                groupBox.ItemsSource = listGroups;

                groupBox.SelectedIndex = 0;

                clientsDataGrid.ItemsSource = Helper.curatorOrTeacher.Lessons.ToList();

                typeLessonBox.SelectedIndex = 0;
            }

 
            firstOpen = false;

        }

        /// <summary>
        /// date update
        /// </summary>
        public void Update()
        {
            try
            {
                if (firstOpen)
                    return;

                var list = Helper.curatorOrTeacher.Lessons.ToList();

                var typeGroup = groupBox.SelectedItem as Group;

                var typeSubject = subjectBox.SelectedItem as Subject;

                var typeLesson = typeLessonBox.SelectedItem as Lesson;


                DateTime lessonDate = lessonDateBox.SelectedDate.Value;

                if (useDate.IsChecked.Value)
                    list = list.Where(a => a.DataLesson == lessonDate).ToList();

                if (typeGroup.ID != -1)
                    list = list.Where(a => a.ID_Group == typeGroup.ID).ToList();

                if (typeSubject.ID != -1)
                    list = list.Where(a => a.ID_Subject == typeSubject.ID).ToList();


                switch (pointAndHoursBox.SelectedIndex)
                {
                    case 1:
                        list = list.OrderBy(a => a.MaxPoint).ToList();
                        break;
                    case 2:
                        list = list.OrderByDescending(a => a.MaxPoint).ToList();
                        break;

                    case 3:
                        list = list.OrderBy(a => a.NumberOfHours).ToList();
                        break;
                    case 4:
                        list = list.OrderByDescending(a => a.NumberOfHours).ToList();
                        break;
                }



                switch (typeLessonBox.SelectedIndex)
                {
                    case 1:
                        list = list.Where(a => a.TypeLesson == "Практика").ToList();
                        break;
                    case 2:
                        list = list.Where(a => a.TypeLesson == "Лекция").ToList();
                        break;

                    case 3:
                        list = list.Where(a => a.TypeLesson == "Курсовая работа").ToList();
                        break;

                }


                clientsDataGrid.ItemsSource = list;

            }
            catch (Exception ex)
            {

                Helper.ShowError("Что-то пошло не так, проверьте корректность данных!");
            }
        }


        /// <summary>
        /// opening various windows
        /// </summary>
        /// <param name="window"></param>
        private void OpenWindow(Window window) => window.ShowDialog();

        /// <summary>
        /// adding an activivty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLesson_Click(object sender, RoutedEventArgs e) => OpenWindow(new AddClassWindow());


       /// <summary>
       /// group filtering
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void groupBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => Update();

        /// <summary>
        /// subject filtering
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subjectBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => Update();

        /// <summary>
        /// edit activivity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditLesson_Click(object sender, RoutedEventArgs e)
        {
            Lesson selected = clientsDataGrid.SelectedItem as Lesson;
            OpenWindow(new AddClassWindow() { DataContext = selected, Lesson = selected });
        }

        /// <summary>
        /// delete activivty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteLesson_Click(object sender, RoutedEventArgs e)
        {
            var lesson = clientsDataGrid.SelectedItem as Lesson;

            if (lesson.LessonStudents.Count > 0)
            {
                Helper.ShowInformation("Урок невозможно удалить");
                return;
            }

            MessageBoxResult result = Helper.ShowQuestion("Вы действительно хотите удалить выбранного студента?");

            if (result == MessageBoxResult.No)
                return;

            Helper.context.Lessons.Remove(lesson);
            Helper.context.SaveChanges();
        }

        /// <summary>
        /// point filtering
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pointBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => Update();

        /// <summary>
        /// typelesson filtering
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void typeLessonBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => Update();

        /// <summary>
        /// clear form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            clientsDataGrid.SelectedItem = null;
            subjectBox.SelectedIndex = 0;
            groupBox.SelectedIndex = 0;
            lessonDateBox.SelectedDate = DateTime.Today;
            useDate.IsChecked = false;
            pointAndHoursBox.SelectedIndex = 0;
        }

        /// <summary>
        /// data lesson filtering
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lessonDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e) => Update();

        /// <summary>
        ///  data filtering
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void useDate_Click(object sender, RoutedEventArgs e) => Update();

    }
}
