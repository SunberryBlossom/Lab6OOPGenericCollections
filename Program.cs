namespace Lab6OOPGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a Stack to contain Employee objects
            Stack<Employee> employeeStack = new Stack<Employee>();

            // Pushing in five new employees with filled in property values
            employeeStack.Push(new Employee { Id = "E001", Name = "Mika", Salary = 25600m, Gender = Gender.Female});
            employeeStack.Push(new Employee { Id = "E002", Name = "Elvira", Salary = 38400m, Gender = Gender.Female });
            employeeStack.Push(new Employee { Id = "E003", Name = "Andreas", Salary = 30000m, Gender = Gender.Male });
            employeeStack.Push(new Employee { Id = "E004", Name = "Sam", Salary = 19800m, Gender = Gender.Other });
            employeeStack.Push(new Employee { Id = "E005", Name = "Hera", Salary = 6000m, Gender = Gender.Female });


            foreach (var employee in employeeStack)
            {
                Console.WriteLine($"Name: {employee.Name}\nWork ID: {employee.Id}\nCurrent Salary: {employee.Salary:C0}\nGender: {employee.Gender}");
                Console.WriteLine($"Items left in the stack: {employeeStack.Count}");
                Console.WriteLine("--------------------------");
            }

        }
    }
}
