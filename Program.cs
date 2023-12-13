namespace C_sharp_1
{
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

            MyInterface x = new Customer();
            x.setData();
            x.getData();
        }
    }
}