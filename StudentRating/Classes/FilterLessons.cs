using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Classes
{
    class FilterLessons
    {

        public List<Lesson> Source { get; set; }
        public List<Lesson> Updated { get; set; }

        public int CountInPage { get; set; } = 20;
        public int CurrentPage { get; set; } = 0;

        public List<Lesson> Offset
            => Updated.Skip(CurrentPage * CountInPage).Take(CountInPage).ToList();

        public Lesson _lessonType { get; set; } = new Lesson();

        public FilterLessons(List<Lesson> lessons)
        {
            Source = lessons;
            Updating();
        }


        public void Updating()
        {
            List<Lesson> lessons = Source;

            if (_lessonType.TypeLesson != null)
                lessons = lessons.Where(c => c.TypeLesson == _lessonType.TypeLesson).ToList();

            Updated = lessons;
        }
    }
}
