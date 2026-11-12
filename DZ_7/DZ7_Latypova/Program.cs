using DZ7_Latypova.Classes;
using DZ7_Latypova.Enums;

namespace DZ7_Latypova
{
    internal class Program
    {
        // Задание №1
        static void Exercise1()
        {
            Console.WriteLine("Задание №1");

            Employee timur = new Employee("Тимур", "Генеральный директор", Department.Management);
            Employee rashid = new Employee("Рашид", "Финансовый директор", Department.Management);
            Employee ilham = new Employee("О Ильхам", "Директор по автоматизации", Department.Management);

            Employee lucas = new Employee("Лукас", "Главный бухгалтер", Department.Accounting);

            Employee orkadiy = new Employee("Оркадий", "Начальник инф систем", Department.IT);
            Employee volodya = new Employee("Володя", "Зам. начальника инф систем", Department.IT);

            Employee ilshat = new Employee("Ильшат", "Главный системщик", Department.SystemAdministrators);
            Employee ivanich = new Employee("Иваныч", "Зам. главного системщика", Department.SystemAdministrators);

            Employee ilya = new Employee("Илья", "Системщик", Department.SystemAdministrators);
            Employee vitya = new Employee("Витя", "Системщик", Department.SystemAdministrators);
            Employee zhenya = new Employee("Женя", "Системщик", Department.SystemAdministrators);

            Employee sergey = new Employee("Сергей", "Главный разработчик", Department.Developers);
            Employee lyaisan = new Employee("Ляйсан", "Зам. главного разработчика", Department.Developers);

            Employee marat = new Employee("Марат", "Разработчик", Department.Developers);
            Employee dina = new Employee("Дина", "Разработчик", Department.Developers);
            Employee ildar = new Employee("Ильдар", "Разработчик", Department.Developers);
            Employee anton = new Employee("Антон", "Разработчик", Department.Developers);

            rashid.AddManager(timur);
            ilham.AddManager(timur);
            lucas.AddManager(rashid);
            orkadiy.AddManager(ilham);
            volodya.AddManager(ilham);

            ilshat.AddManager(orkadiy);
            ilshat.AddManager(volodya);

            sergey.AddManager(orkadiy);
            sergey.AddManager(volodya);

            ivanich.AddManager(ilshat);
            ilya.AddManager(ivanich);
            vitya.AddManager(ivanich);
            zhenya.AddManager(ivanich);

            lyaisan.AddManager(sergey);
            marat.AddManager(lyaisan);
            dina.AddManager(lyaisan);
            ildar.AddManager(lyaisan);
            anton.AddManager(lyaisan);

            WorkTask task1 = new WorkTask("Обновить антивирусные базы на серверах", Department.SystemAdministrators);
            WorkTask task2 = new WorkTask("Написать код для бухгалтерии", Department.Developers);
            WorkTask task3 = new WorkTask("Подготовить план развития", Department.Management);
            WorkTask task4 = new WorkTask("Разработать программу 'Кнопочка' для автоматизации бухгалтерии", Department.Developers);


            ilshat.AssignTask(volodya, task1);

            dina.AssignTask(lyaisan, task2);

            rashid.AssignTask(timur, task3);

            ilya.AssignTask(ivanich, task1);

            dina.AssignTask(timur, task2);

            ilshat.AssignTask(lyaisan, task2);
        }

        static void Main(string[] args)
        {
            Exercise1();
            Console.ReadKey();
        }
    }
}
