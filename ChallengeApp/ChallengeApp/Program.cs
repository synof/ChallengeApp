using ChallengeApp;

Employee Employee1 = new Employee("Maks", "Buller", "29");
Employee Employee2 = new Employee("Iwona", "Zió³kowska", "30");
Employee Employee3 = new Employee("Dominika", "Brzustowska", "33");

Employee1.AddScore(8);
Employee1.AddScore(9);
Employee1.AddScore(3);
Employee1.AddScore(9);
Employee1.AddScore(2);

Employee2.AddScore(6);
Employee2.AddScore(9);
Employee2.AddScore(3);
Employee2.AddScore(5);
Employee2.AddScore(4);

Employee3.AddScore(9);
Employee3.AddScore(6);
Employee3.AddScore(9);
Employee3.AddScore(5);
Employee3.AddScore(3);

List<Employee> Employees = new List<Employee>()
{
    Employee1, Employee2, Employee3
};

int maxResult = -1;
Employee EmployeeWithMaxResult = null;

foreach (var employee in Employees)
{
    if (employee.Result > maxResult)  
    {
        maxResult = employee.Result;
        EmployeeWithMaxResult = employee; 
    } 
}
Console.WriteLine("Pracownik z najwiêksz¹ liczb¹ punktów: " + EmployeeWithMaxResult.Name + " " + EmployeeWithMaxResult.SurName);
Console.WriteLine("Wiek : " + EmployeeWithMaxResult.Age);
Console.WriteLine("Iloœæ zebranych punktów: " + maxResult);