namespace Lab6OOPGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a Stack to contain Employee objects
            Stack<Employee> employeeStack = new Stack<Employee>();


            // Creating five employees
            Employee Mika = new Employee("E001", "Mika Mikasdotter", Gender.Female, 25600);
            Employee Elvira = new Employee("E002", "Elvira Mariesdotter", Gender.Female, 38400);
            Employee Sam = new Employee("E003", "Sam Samssen", Gender.Other, 16700);
            Employee Andreas = new Employee("E004", "Andreas Andreasson", Gender.Male, 30000);
            Employee Hera = new Employee("E005", "Hera Hund", Gender.Female, 6050);


            // Pushing in five new employees with filled in property values
            employeeStack.Push(Mika);
            employeeStack.Push(Elvira);
            employeeStack.Push(Sam);
            employeeStack.Push(Andreas);
            employeeStack.Push(Hera);


            // Print out all employees in the stack with the help of a foreach loop
            Console.WriteLine("Retrieving all employees with console writelines and foreach loop. . .");
            foreach (var employee in employeeStack)
            {
                Console.WriteLine($"Name: {employee.Name}\nWork ID: {employee.Id}\nCurrent Salary: {employee.Salary:C0}\nGender: {employee.Gender}");
                Console.WriteLine($"Items left in the stack: {employeeStack.Count}");
                Console.WriteLine("--------------------------\n");
            }

            // Print out all employees through the Pop method
            // Since we are removing items from the Stack, i with a value of stack.count, and reduces by 1 every iteration.
            // Once the stack reaches 0, the loop wont start.
            Console.WriteLine("Retrieving all employees using Pop method. . .");
            for(int i = employeeStack.Count; i > 0; i--)
            {
                Employee currentEmployee = employeeStack.Pop();

                Console.WriteLine($"Name: {currentEmployee.Name}\nWork ID: {currentEmployee.Id}\nCurrent Salary: {currentEmployee.Salary:C0}\nGender: {currentEmployee.Gender}");
                Console.WriteLine($"Items left in the stack: {employeeStack.Count}");
                Console.WriteLine("--------------------------\n");
            }

            // Push the objects back into the stack
            employeeStack.Push(Mika);
            employeeStack.Push(Elvira);
            employeeStack.Push(Sam);
            employeeStack.Push(Andreas);
            employeeStack.Push(Hera);


            // Print out employees of the stack using the Peek method.
            // Since we now that we want to only print two members of the list, we can set i to stop after two iterations.
            Console.WriteLine("Retrieving employees using Peek method. . .");
            for (int i = 0; i < 2; i++)
            {
                Employee emp = employeeStack.Peek();
                Console.WriteLine($"Name: {emp.Name}\nWork ID: {emp.Id}\nCurrent Salary: {emp.Salary:C0}\nGender: {emp.Gender}");
                Console.WriteLine($"Items left in the stack: {employeeStack.Count}");
                Console.WriteLine("--------------------------\n");
            }


            // Sam is the object num 3 in the stack. If Sam is still in the stack, Contains will return true and the writeline will print.
            if(employeeStack.Contains(Sam))
            {
                Console.WriteLine("Employee 3 is in stack");
            }
        }
    }
}
