using oops;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        //delegate example
        //DelegateExample delegateExample = new DelegateExample();
        //delegateExample.calculateResult(10, 5, delegateExample.Add);

        //func and predicate example

        //FuncandPredicatedelegate funcandPredicatedelegate = new FuncandPredicatedelegate();
        //int result = funcandPredicatedelegate.calculate(10, 5, funcandPredicatedelegate.add);
        //bool isEven = funcandPredicatedelegate.IsEven(10, funcandPredicatedelegate.isEvenNumber);


        //Event Exaample

        //EventExample eventExample = new EventExample();
        //Notification notification = new Notification();

        //eventExample.Click += notification.SendSMS;

        //eventExample.buttonclick();


        //RACE CONDITION

        //RaceConditionExample raceConditionExample = new RaceConditionExample();
        // raceConditionExample.IncrementCounter();
        //raceConditionExample.Print();



        //Extension Method

        //ExtensionMethod extensionMethodClass = new ExtensionMethod();
        //extensionMethodClass.FirstName = "John";
        //extensionMethodClass.LastName = "Doe";
        //Console.WriteLine( extensionMethodClass.Welcome());

        //List<Employee> employees = new List<Employee>();
        //employees.Add(new PermanentEmployee());
        //employees.Add(new ContractEmployee());
        //employees[0].Name = "John Doe";
        //employees[0].Email = "Tes@gmail.com";
        //employees[0].Phone = "1234567890";
        //employees[0].Salary = "50000";
        //employees[1].Name = "Jane Smith";
        //employees[1].Email = "test2,com";
        //employees[1].Phone = "0987654321";
        //employees[1].Salary = "30000";
        //foreach (var employee in employees)
        //{
        //    employee.ShowInfo();
        //    decimal bonus = employee.CalculateBonus(1000);
        //    Console.WriteLine($"Bonus for {employee.Name}: {bonus}");
        //}


        // Method Overloading

        //    MethodOveriding obj1 = new MethodOveriding();
        //   obj1.Show();

        //   MethodOveriding obj2 = new DerivedClass();
        //   obj2.Show();

        //MethodOveriding obj3 = new ChildClass();
        //obj3.Show();

        //Abstraction abstraction = new DerivedAbstraction();
        //abstraction.Show();
        // DerivedAbstraction derivedAbstraction = new DerivedAbstraction();
        //derivedAbstraction.Show();
        //    IAbstraction iAbstraction = new DerivedInterface();
        //iAbstraction.Show();

        Encapsulation encapsulation = new Encapsulation();
            encapsulation.SetBankBalance(1000.87m);
        encapsulation.Withdraw(200.50m);
        Console.WriteLine($"Current Bank Balance: {encapsulation.GetBankBalance()}");
       


        //Console.WriteLine("Hello, World!");
    }
}