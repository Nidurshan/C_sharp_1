using C_sharp_1.Practice_1;
using C_sharp_1.Practice_2;
using C_sharp_1.Practice_3;
using System.Data.Common;
using System.IO;
//using C_sharp_1.Practice_4;

namespace C_sharp_1
{
    //class Student_3
    //{
    //    static public int total_student = 0;
    //    public int roll;
    //    public string name;
    //    public int score;

    //    public Student_3(int roll, string name, int score)
    //    {
    //        this.roll = roll;
    //        this.name = name;
    //        this.score = score;
    //        total_student++;
    //    }
    //}

    //---------------------------------------------

    //class Circle
    //{
    //    //public static int radius;
    //    public static float pi = 3.14F;
    //    //public double pi2 = 3.14;


    //    public static float area(int radius)
    //    {
    //        return pi * radius * radius;
    //    }
    //}

    //----------------------------------------------

    //class Employee
    //{
    //    public int id;
    //    public string name;
    //    public int salary;

    //    public Employee(int id, string name, int salary)
    //    {
    //        this.id = id;
    //        this.name = name;
    //        this.salary = salary;
    //    }

    //    public Employee(int id, int salary)
    //    {
    //        this.id = id;
    //        this.salary = salary;
    //    }

    //    public Employee()
    //    {
    //    }

    //    public void setData()
    //    {
    //        Console.Write("Enter ID: ");
    //        id = int.Parse(Console.ReadLine());

    //        Console.Write("Enter Name: ");
    //        name = Console.ReadLine();

    //        Console.Write("Enter Salary: ");
    //        salary = int.Parse(Console.ReadLine());
    //    }

    //    public void setData(int id, string name, int salary)
    //    {
    //        this.id = id;
    //        this.name = name;
    //        this.salary = salary;
    //    }

    //    public virtual void display()
    //    {
    //        Console.WriteLine(id + "\t" + name);
    //    }
    //}

    //class TempEmployee : Employee
    //{
    //    public TempEmployee(int id, string name, int salary) : base(id, name, salary)
    //    {

    //    }

    //    public override void display()
    //    {
    //        Console.WriteLine("Temp: " + id + "\t" + name);
    //    }
    //}

    //------------------------------------------------------------------------------------

    //class Employee
    //{
    //    public int id;
    //    public string name;
    //    public int salary;

    //    public Employee(int id, string name, int salary)
    //    {
    //        this.id = id;
    //        this.name = name;
    //        this.salary = salary;
    //    }

    //    public Employee(int id, int salary)
    //    {
    //        this.id = id;
    //        this.salary = salary;
    //    }

    //    public Employee()
    //    {
    //    }

    //    public void setData()
    //    {
    //        Console.Write("Enter ID: ");
    //        id = int.Parse(Console.ReadLine());

    //        Console.Write("Enter Name: ");
    //        name = Console.ReadLine();

    //        Console.Write("Enter Salary: ");
    //        salary = int.Parse(Console.ReadLine());
    //    }

    //    public void setData(int id, string name, int salary)
    //    {
    //        this.id = id;
    //        this.name = name;
    //        this.salary = salary;
    //    }

    //    public virtual void display()
    //    {
    //        Console.WriteLine(id + "\t" + name);
    //    }
    //}

    //class TempEmployee : Employee
    //{
    //    public TempEmployee(int id, string name, int salary) : base(id, name, salary)
    //    {
    //    }

    //    public override void display()
    //    {
    //        Console.WriteLine("T: " + id + "\t" + name);
    //    }
    //}

    //class Per_Employee : Employee
    //{
    //    public Per_Employee(int id, string name, int salary) : base(id, name, salary)
    //    {
    //    }

    //    public override void display()
    //    {
    //        Console.WriteLine("P: " + id + "\t" + name);
    //    }
    //}

    //------------------------------------------------------------------------------------------

    //class Circle
    //{
        //private int radius;
        //private float pi = 3.14f;

        //public int R
        //{
        //    get
        //    {
        //        return radius;
        //    }
        //    set 
        //    {
        //        if(value > 0)
        //        {
        //            radius = value;
        //        }
        //        else
        //        {
        //            radius = 1;
        //        }
        //    }
        //}

    //    int R;
    //    public int r {
    //        get
    //        {
    //            return R;
    //        }
    //        set
    //        {
    //            if (value > 0)
    //                R = value;
    //            else
    //                R = 1;
    //        }
    //    }

    //    private float pi = 3.14f;

    //    public void Area()
    //    {
            //Console.WriteLine(pi * r * r);
    //    }
    //}

    //class Employee
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public int salary { get; set; }
    //}

    //-------------------------------------------------------------------------------

    //struct Employee
    //{
    //    public int id;
    //    public string name;
    //    public int salary;

    //    public Employee(int id, string name, int salary)
    //    {
    //        this.id = id;
    //        this.name = name;
    //        this.salary = salary;
    //    }

    //    public void display()
    //    {
    //        Console.WriteLine(id + "\t" + name + "\t" + salary);
    //    }

    //    public void accept()
    //    {
    //        Console.Write("Enter ID: ");
    //        id = int.Parse(Console.ReadLine());

    //        Console.Write("Enter Name: ");
    //        name = Console.ReadLine();

    //        Console.Write("Enter Salary: ");
    //        salary = int.Parse(Console.ReadLine());
    //    }
    //}

    public class Program
    {
        public static void Main(string[] args)
        {

            //================= Introduction ===================

            // Console.WriteLine("Welcome to C# Programming");
            // int x, y, tota3l;
            // x = 10;
            // y = 20;
            // total = x + y;
            // Console.WriteLine("Total: " + total);
            // Console.WriteLine($"Total: {total}");

            //================ User Input & Type Conversion ================

            // int p, n, r, si;
            // Console.Write("Enter value for P: ");
            // p = int.Parse(Console.ReadLine());

            // Console.Write("Enter value for N: ");
            // n = int.Parse(Console.ReadLine());

            // Console.Write("Enter value for R: ");
            // r = Convert.ToInt32(Console.ReadLine());

            // si = (p * n * r) / 100;
            // Console.WriteLine($"Simple Intrest: {si}");

            //================ Decision Making Statements ==================

            // int janSales, febSales, marSales, total, average;

            // Console.Write("Enter sales for Jannuary: ");
            // janSales = int.Parse(Console.ReadLine());

            // Console.Write("Enter sales for February: ");
            // febSales = int.Parse(Console.ReadLine());

            // Console.Write("Enter sales for March: ");
            // marSales = int.Parse(Console.ReadLine());

            // total = janSales + febSales + marSales;
            // Console.WriteLine($"Total: {total}");

            // average = total / 3;
            // Console.WriteLine($"Average: {average}");

            // int inc;
            // if (janSales >= 15 && febSales >= 15 && marSales >= 15)
            // {
            //     if (average >= 75)
            //     {
            //         inc = (total * 20) / 100;
            //     }
            //     else if(average >= 50)
            //     {
            //         inc = (total * 10) / 100;
            //     }
            //     else if(average >= 25)
            //     {
            //         inc = (total * 5) / 100;
            //     }
            //     else
            //     {
            //         inc = 0;
            //     }
            // }
            // else
            // {
            //     inc = 0;
            // }
            // Console.WriteLine($"Incentive: {inc}");

            //======================= Switch Case =======================

            // int currentReading, previousReading, unit, rate, amount;
            // string type;

            // Console.Write("Enter Current Reading: ");
            // currentReading = int.Parse(Console.ReadLine());

            // Console.Write("Enter Previous Reading: ");
            // previousReading = int.Parse(Console.ReadLine());

            // unit = Math.Abs(currentReading - previousReading);

            // Console.Write("Enter Connection Type: ");
            // // type = Convert.ToChar(Console.ReadLine());
            // type = Console.ReadLine();

            // switch (type)
            // {
            //     case "D":
            //         rate = 2;
            //         break;
            //     case "I":
            //         rate = 6;
            //         break;
            //     case "C":
            //         rate = 4;
            //         break;
            //     default:
            //         Console.WriteLine("Invalid Input!");
            //         rate = 0;
            //         break;
            // }
            // amount = unit * rate;
            // Console.WriteLine($"Bill Amount: {amount}");

            //======================== For Loop ==========================

            // for(int i = 1; i <= 20; i++)
            // {
            //     Console.WriteLine(i + "x" + 5 + "=" + (i * 5));
            // }

            // Console.Write("Enter a Number: ");
            // int n = int.Parse(Console.ReadLine());
            // int result = 0;

            // for(int i = 2; i < n; i++)
            // {
            //      if(n % i == 0)
            //      {
            //         result = 1;
            //         break;
            //      }
            // }

            // if(result == 0)
            // {
            //     Console.WriteLine($"{n} is Prime");
            // }
            // else
            // {
            //     Console.WriteLine($"{n} is not a Prime");
            // }

            //=============== While Loop and Do While Loop ==================

            // int x = 0;

            // do
            // {
            //     Console.WriteLine(!(x >= 10));
            //     x++;
            // } while(x < 10);

            // int x, y;


            // Console.Write("Enter value for x: ");
            // x = int.Parse(Console.ReadLine());

            // Console.Write("Enter value for y: ");
            // y = int.Parse(Console.ReadLine());

            // int a, b;
            // a=x;
            // b=y;

            // int total = 0;
            // while(x > 0)
            // {
            //     if (x % 2 != 0)
            //     {
            //         total += y;
            //     }
            //     x = x / 2;
            //     y = y * 2;
            // }
            // Console.WriteLine($"Product of {a} and {b} is {total}");


            // string name = "";
            // while(name != "END")
            // {
            //     Console.Write(name);
            //     Console.Write(" Enter Your Name: ");
            //     name = Console.ReadLine();
            // }

            //=========================== Arrays ==============================

            // int[] sales = new int[3];
            // string[] months = { "Jan", "Feb", "Mar" };

            // for (int i = 0; i < months.Length; i++)
            // {
            //     Console.Write($"Enter Sales for {months[i]}: ");
            //     sales[i] = int.Parse(Console.ReadLine());
            // }

            // int total = 0;

            // for (int i = 0; i < months.Length; i++)
            // {
            //     Console.WriteLine($"{months[i]}\t{sales[i]}");
            //     total += sales[i];
            // }
            // Console.WriteLine($"Total: {total}");

            // foreach (int x in sales)
            // {
            //     Console.WriteLine(x);
            // }

            // Array.Sort(sales);
            // foreach (int x in sales)
            // {
            //     Console.WriteLine(x);
            // }

            // for (int i = 0; i < sales.Length; i++)
            // {
            //     for (int j = 0; j < sales.Length; j++)
            //     {
            //         if (sales[i] > sales[j])
            //         {
            //             int tmp = sales[i];
            //             sales[i] = sales[j];
            //             sales[j] = tmp;
            //         }
            //     }
            // }

            // foreach (int x in sales)
            // {
            //     Console.WriteLine(x);
            // }

            //=========== Double Dimensional Array =============

            // string[] months = { "Jan", "Feb", "Mar" };
            // int[,] sales = new int[3, 3];

            // for (int i = 0; i < sales.GetLength(0); i++)
            // {
            //     Console.WriteLine($"Enter Sales for Salesman-{i + 1}: ");
            //     for (int j = 0; j < sales.GetLength(1); j++)
            //     {
            //         Console.Write($"Enter Sales for {months[j]}: ");
            //         sales[i, j] = int.Parse(Console.ReadLine());
            //     }
            // }

            // for (int i = 0; i < sales.GetLength(0); i++)
            // {
            //     Console.Write($"Salesman-{i + 1}\t");
            //     int total = 0;
            //     for (int j = 0; j < sales.GetLength(1); j++)
            //     {
            //         Console.Write($"{sales[i, j]}\t");
            //         total += sales[i, j];
            //     }
            //     Console.WriteLine(total);
            // }

            //===================== Jagged Array =======================

            // int[][] player = new int[3][];

            // for (int i = 0; i < player.GetLength(0); i++)
            // {
            //     Console.WriteLine($"Enter Scores for Player-{i + 1}: ");
            //     Console.Write("Enter Number of Maches Played: ");
            //     int n = int.Parse(Console.ReadLine());

            //     player[i] = new int[n];
            //     for (int j = 0; j < player[i].Length; j++)
            //     {
            //         Console.Write($"Enter Score for Match {j + 1}: ");
            //         player[i][j] = int.Parse(Console.ReadLine());
            //     }
            // }

            // for (int i = 0; i < player.GetLength(0); i++)
            // {
            //     Console.Write($"Player-{i + 1}\t");
            //     int total = 0;
            //     for (int j = 0; j < player[i].Length; j++)
            //     {
            //         Console.Write($"{player[i][j]}\t");
            //         total += player[i][j];
            //     }
            //     Console.WriteLine(total);
            // }

            //=================== Object Orientation ======================

            // Student s = new Student();
            // s.SetData();
            // s.GetData();
            // Student t = new Student(12, "Sam", 455);

            //======================== Inheritance =========================

            //SchoolStudent s = new SchoolStudent(10, "Harry", 580, 10, "A");
            //s.GetData();

            //=================== Multilevel Inheritance ====================

            //HrStudent s = new HrStudent();
            ////Student s = new HrStudent();
            //s.SetData();
            //s.GetData();

            //======================== Abstract Class =========================

            //Shape s = new Rectrangle();
            //Rectrangle s = new Rectrangle();

            //======================== Interface ==========================

            //MyInterface x = new Customer();
            //x.setData();
            //x.getData();

            //================ Static Members and Instance Members =================

            //Student_3 s = new Student_3(1, "John", 500);
            //Student_3 s2 = new Student_3(2, "Harry", 475);
            //Student_3 s3 = new Student_3(3, "Tom", 495);

            //Console.WriteLine(Student_3.total_student);

            //Console.WriteLine(Circle.area(15));

            //======================== Polymorphism =======================

            //Employee e = new Employee(2, "John", 45000);
            ////Employee e1 = new Employee(2, "John", 55000);
            ////Employee e2 = new Employee();

            ////e2.setData(3, "John", 15000);

            //TempEmployee e1 = new TempEmployee(2, "Jack", 35000);
            //e.display();
            //e1.display();

            //================== Hiding vs Overriding ====================

            // if you want to hide, use the new keyword

            //Employee e = new Employee(1, "John", 45000);
            //Employee e1 = new TempEmployee(2, "Jack", 35000);
            //Employee e2 = new Per_Employee(3, "Harry", 35000);
            //e.display();
            //e1.display();
            //e2.display();

            //========================== Properties =========================

            //Circle c = new Circle();
            //c.R = -121;
            //c.Area();

            //Circle c = new Circle() { r = -12 };
            //c.Area();

            //Employee e = new Employee() { id = 1, name = "Peter", salary = 100000 };

            //=========================== Structures =========================

            //Employee e = new Employee(1, "Peter", 50000);
            //e.display();

            //Employee emp = new Employee();
            ////emp.id = 1;
            ////emp.name = "John";
            ////emp.salary = 50000;
            ////emp.display();
            //Employee e1;
            //e1.id = 10;
            //e1.name = "Peter";
            //e1.salary = 10000;
            //e1.display();

            //e1 = emp;
            //e1.id = 15;
            //emp.display();
            //e1.display();

            //Employee[] employees = new Employee[3];
            //for(int i = 0; i < employees.Length; i++) 
            //{
            //    employees[i].accept();
            //}
            //foreach(Employee e in employees)
            //{
            //    emp.display();
            //}

            //============================== File Handling ================================
            // Use this in file handling: Using System.IO

            //FileStream fs = new FileStream(@"c:\Users\Nidurshan\Desktop\Sample.txt", FileMode.OpenOrCreate);
            //StreamWriter w = new StreamWriter(fs);

            //w.WriteLine("This is a sample document.");
            //w.WriteLine("This document is created using C# program");
            //w.Close();
            //fs.Close();

            //FileStream fs = new FileStream(@"c:\Users\Nidurshan\Desktop\Sample.txt", FileMode.OpenOrCreate);
            //StreamReader r = new StreamReader(fs);

            //string line = r.ReadLine();

            //while (line != null)
            //{
            //    Console.WriteLine(line);
            //    line = r.ReadLine();
            //}

            //FileStream fs = new FileStream(@"c:\Users\Nidurshan\Desktop\books.txt", FileMode.OpenOrCreate);
            //StreamWriter w = new StreamWriter(fs);

            //string answer = "Y";

            //while (answer == "Y")
            //{
            //    Console.Write("Enter Book ID: ");
            //    string id = Console.ReadLine();

            //    Console.Write("Enter Book Title: ");
            //    string title = Console.ReadLine();

            //    Console.Write("Enter Book Author: ");
            //    string author = Console.ReadLine();

            //    string line = $"{id},{title},{author}";
            //    w.WriteLine(line);

            //    Console.Write("Do you want to Add More Y/N: ");
            //    answer = Console.ReadLine();
            //}
            //w.Close();
            //fs.Close();

            //FileStream fs2 = new FileStream(@"c:\Users\Nidurshan\Desktop\books.txt", FileMode.OpenOrCreate);
            //StreamReader r = new StreamReader(fs2);

            //string line2 = r.ReadLine();

            //while (line2 != null)
            //{
            //    string[] cols = line2.Split(',');
            //    Console.WriteLine("ID     : " + cols[0]);
            //    Console.WriteLine("Title  : " + cols[1]);
            //    Console.WriteLine("Author : " + cols[2]);

            //    line2 = r.ReadLine();
            //}
            //r.Close();
            //fs2.Close();

            //=========================== Exception Handling ============================

            //int x, y, z;
            //int[] arr = { 12, 13, 14 };

            //z = 0;

            //Console.Write("Enter value for x: ");
            //x = int.Parse(Console.ReadLine());

            //Console.Write("Enter vlaue for y: ");
            //y = int.Parse(Console.ReadLine());

            //try
            //{
            //    z = x / y;
            //    Console.WriteLine(arr[5]);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("y value cannot be zero, rerun the program with a right value");
            //    while (y == 0)
            //    {
            //        Console.Write("Enter Non zero value for Y: ");
            //        y = int.Parse(Console.ReadLine());
            //    }
            //    z = x / y;
            //}
            //catch (IndexOutOfRangeException e2)
            //{
            //    int n = -1;
            //    while(n < 0 || n >= arr.Length)
            //    {
            //        Console.Write("Enter Proper Index: ");
            //        n = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine(arr[n]);
            //}

            //z = x / y;
            //Console.WriteLine("Result: " + z);

            //===================== Advanced Level Exception Handling =====================

            int x = 5;
            int y = 10;
            try
            {
                int z = x / y;
                try
                {
                    int[] arr = { 12, 13, 14 };
                    int a = 10;
                    // Here is an ArithmeticException
                    int b = 0;
                    int c = a / b;
                    // Here is an IndexOutOfRangeException
                    Console.WriteLine(arr[12]);
                }
                catch (IndexOutOfRangeException e1)
                {
                    Console.WriteLine("Index Error!!");
                }
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Error!!");
            }

            //==================================================================================================================================
            //==================================================================================================================================

            //Person student = new Student_2();
            //student.SetData();
            //student.GetData();

            //Shape_2 shape = new Shape_2();
            //shape.SetValues();

            //Squre squre = new Squre();
            //squre.Find_Area();

            //var printDateTime = new PrintDateTime();
            //printDateTime.PrintCurrentDateTime();
        }
    }
}