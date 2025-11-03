using API_CRUD.Models;
namespace API_CRUD.Servies
{
    public class EmployeeService
    {
        static List<Employee> employeeslist { get; }
        static int nextempid = 3;

        static EmployeeService()
        {
            employeeslist = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Ayman", title = "Developer", salary = 1000 },
                new Employee() { Id = 2, Name = "mahmoud", title = "CEO", salary = 2000 }
            };
        }

        public static List<Employee> GetAll() => employeeslist;
        public static Employee Get(int id) => employeeslist.FirstOrDefault(p => p.Id == id);
         
        public static void Add(Employee employee)
        {
            employee.Id = nextempid++;
            employeeslist.Add(employee);
        }

        public static void Update(Employee employee)
        {
            var index = employeeslist.FindIndex(p=>p.Id == employee.Id);
            if (index == -1)
                return;
            employeeslist[index] = employee;
        }

        public static void Delete(int id)
        {
            var employee =Get(id);
            if (employee is null)
                return;
            employeeslist.Remove(employee);
        }
        
        
    }
}
