using DZ7_Latypova.Enums;

namespace DZ7_Latypova.Classes
{
    public class WorkTask
    {
        public string Title { get; set; } // Название задачи
        public Department Target { get; set; } // Для кого задача

        public WorkTask(string title, Department target)
        {
            Title = title;
            Target = target;
        }
    }
}
