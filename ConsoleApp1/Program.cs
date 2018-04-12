using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Course
    {
        readonly private Dictionary<string, string> _courses;
        public Course()
        {
            _courses = new Dictionary<string, string>();
        }
        public string this[string name]
        {
            get
            {
                return _courses[name];
            }
            set
            {
                _courses[name] = value;
            }
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public int Age { get { return DateTime.Now.Year - YearOfBirth; } private set { } }
    }

    public abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape Constructor");
        }
        public string Name { get; set; }
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public Circle()
        {
            Console.WriteLine("Circle Contructor");
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing Cirlce");
        }
    }

    public class Square : Shape
    {
        public Square()
        {
            Console.WriteLine("Square Contructor");
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }

    public class HttpCookie
    {
        readonly Dictionary<string, string> cookies = new Dictionary<string, string>();
        public string this[string name]
        {
            get
            {
                return cookies[name];
            }
            set
            {
                cookies[name] = value;
            }
        }
    }

    class Program
    {
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar.Length; j++)
                {
                    if ((j + 1 != ar.Length)&& i!=j)
                    {
                        if ((ar[i] < ar[j]) && ((ar[i] + ar[j]) % k == 0))
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        static void Main(String[] args)
        {

            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
