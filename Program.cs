namespace Lab6OOPGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a Stack with five objects in
            Stack<Employee> employeeStack = new Stack<Employee>();

            // Pushing in five new employees with filled in property values
            employeeStack.Push(new Employee { Id = "E001", Name = "Mika", Salary = 25600m, Gender = Gender.Female});
            employeeStack.Push(new Employee { Id = "E002", Name = "Elvira", Salary = 38400m, Gender = Gender.Female });
            employeeStack.Push(new Employee { Id = "E003", Name = "Andreas", Salary = 30000m, Gender = Gender.Male });
            employeeStack.Push(new Employee { Id = "E004", Name = "Sam", Salary = 19800m, Gender = Gender.NonBinary });
            employeeStack.Push(new Employee { Id = "E005", Name = "Hera", Salary = 6000m, Gender = Gender.Female });


        }
    }
}
