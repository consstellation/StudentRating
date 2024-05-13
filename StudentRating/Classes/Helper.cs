using System.Windows;
using System.Windows.Controls;
using WpfApp1.Model;

namespace WpfApp1.Classes
{
    class Helper
    {
        public static Frame frame;


        public static bool CheckAdmin;

        //public static CuratorOrTeacher curatorOrTeacher;
        public static CuratorOrTeacher curatorOrTeacher;

        public static NormEntities context = new NormEntities();

        /// <summary>
        /// Окно для вывода информации
        /// </summary>
        /// <param name="text"></param>
        public static void ShowInformation(string text)
            => MessageBox.Show(text, "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

        /// <summary>
        /// Окно для вывода предупреждения
        /// </summary>
        /// <param name="text"></param>
        public static void ShowWarning(string text)
            => MessageBox.Show(text, "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);

        /// <summary>
        /// Окно для вывода ошибки
        /// </summary>
        /// <param name="text"></param>
        public static void ShowError(string text)
            => MessageBox.Show(text, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);


        public static MessageBoxResult ShowQuestion(string text)
                => MessageBox.Show(text, "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
    }
}

