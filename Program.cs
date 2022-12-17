// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

public class Person
{
    public string Name;
    public int Age;
    public Person(string name, int age)
    {
        if (name == "" || name == null || name.Length >= 32)
        {
            Console.WriteLine("Invalid name");
            return;
        }
        if (age <=0 || age>=128)
        {
            Console.WriteLine("Invalid age");
            return;


        }



        {
            Name = name;
            Age = age;
        }
    }
         

    
    public virtual void Print() { }
    }
//Create a Student class extends from Person class 
public class Student : Person
{




public int Year;
    public float Gpa;
   
    public Student(string name,int age ,int year ,float gpa)
        :base( name, age) {
        Year = year;
        Gpa = gpa;
        //Add Validation in the Student class to match the following: -
        // Year should between 1 and 5
        // Gpa should between 0 and 4
        if (Year < 0 || Year > 5)
        {

            Console.Write("Invalid year");
            return;
        }
        if (gpa < 0 || Year > 4)
        {

            Console.Write("Invalid gpa");
            return;
        }

    }
       
public override void Print()
    {
        Console.WriteLine($"My name is {Name},my age is { Age} and my gpa is { Gpa}");
    }
}
public class Database
{
    public Person[] people = new Person[50];
    private int count;
    public void AddStudent(Student student)
    {
        people[count++] = student;
    }
    public void AddStaff(Staff staff)
    {
        people[count++] = staff;
    }
    public void Addpeson(Person person)
    {
        people[count++] = person;
    }
    public void PrintAll()
    {
        foreach (var item in people)
        {
            item?. Print();
        }
    }


}
public class Staff : Person
{
    public double Salary;
    public int JoinYear;
    public Staff(string name, int age, double salary, int joinyear)
        : base(name, age)
    {
        Salary = salary;
        JoinYear = joinyear;
        //Salary should be more than zero and no more than 120,000
       // JoinYear should be more than age by 21 years

        if (salary < 0 || salary > 120000)
        {

            Console.Write("Invalid salary");
            return;
        }
        if (joinyear < 21)
        {

            Console.Write("Invalid joinyear");
            return;
        }


    }
  
    public override void Print()
    {
        Console.WriteLine($"My name is {Name},my age is {Age} and my salary is {Salary}");
    }
}
public class program
{
    public static void Main()
    {
        var database = new Database();
        while (true) {




            Console.Write("1) student , 2)staff ,3)person ,4)print all");
            Console.WriteLine("option");
            var option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("name==>");
                    var name = Console.ReadLine();
                    Console.Write("age==>");
                    var age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("year==>");
                    var year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("gpa==>");
                    var gpa = Convert.ToSingle(Console.ReadLine());
                    var student = new Student(name, age, year, gpa);
                    database.AddStudent(student);


                    break;
                case 2:
                    //(string name, int age, double salary, int joinyear)
                    Console.Write("name==>");
                    var name2 = Console.ReadLine();
                    Console.Write("age==>");
                    var age2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("salary==>");
                    var salary = Convert.ToDouble(Console.ReadLine());
                    Console.Write("joinyear==>");
                    var joinyear = Convert.ToInt32(Console.ReadLine());
                    var staff = new Staff(name2, age2, salary, joinyear);
                    database.AddStaff(staff);
                    





                    break;
                case 3:
                    Console.Write("name==>");
                    var name3= Console.ReadLine();
                    Console.Write("age==>");
                    var age3 = Convert.ToInt32(Console.ReadLine());

                    var person = new Person(name3, age3);

                    break;

                case 4:

                    database.PrintAll();


                    break;
                default:
                    return;




            }
        }
    }
}