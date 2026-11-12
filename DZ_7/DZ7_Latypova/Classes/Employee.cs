using DZ7_Latypova.Enums;

namespace DZ7_Latypova.Classes
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public Department Department { get; set; } // Отдел сотрудника
        public List<Employee> DirectManagers { get; set; } // Начальники

        public Employee(string name, string position, Department department = Department.Management)
        {
            Name = name;
            Position = position;
            Department = department;
            DirectManagers = new List<Employee>();
        }

        public void AddManager(Employee manager)
        {
            if (manager != null && !DirectManagers.Contains(manager))
            {
                DirectManagers.Add(manager);
            }
        }

        public void AssignTask(Employee manager, WorkTask task)
        {
            Console.WriteLine($"От {manager.Name} ({manager.Position}) даётся задача «{task.Title}» сотруднику {Name} ({Position}).");

            bool isDirectManager = DirectManagers.Contains(manager);

            bool isTargetMatch = Department == task.Target;

            if (isDirectManager && isTargetMatch)
            {
                Console.WriteLine($"{Name} берёт задачу");
            }
            else
            {
                string reason;

                if (!isDirectManager)
                {
                    reason = $"{manager.Name} не является прямым руководством данного сотрудника";
                }
                else
                {
                    reason = "задача не соответствует деятельности сотрудника в данном отделе";
                }

                Console.WriteLine($"{Name} не берёт задачу, так как {reason}");
            }
        }
    }
}
