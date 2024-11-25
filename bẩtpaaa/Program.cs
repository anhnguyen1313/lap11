using System;

namespace Shape
{
    // Lớp Circle cơ bản
    public class Circle
    {
        public double Radius { get; set; } = 1.0; // Bán kính mặc định
        public string Color { get; set; } = "red"; // Màu mặc định
        public bool Filled { get; set; } = true; // Trạng thái đầy mặc định

        // Constructor mặc định
        public Circle() { }

        // Constructor với bán kính
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Constructor đầy đủ
        public Circle(double radius, string color, bool filled)
        {
            Radius = radius;
            Color = color;
            Filled = filled;
        }

        // Ghi đè phương thức ToString
        public override string ToString()
        {
            return $"Circle[radius={Radius}, color={Color}, filled={Filled}]";
        }
    }

    // Lớp ComparableCircle kế thừa Circle và triển khai IComparable
    public class ComparableCircle : Circle, IComparable<ComparableCircle>
    {
        public ComparableCircle() { }

        public ComparableCircle(double radius) : base(radius) { }

        public ComparableCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

        // Triển khai phương thức CompareTo
        public int CompareTo(ComparableCircle other)
        {
            if (this.Radius > other.Radius) return 1;
            else if (this.Radius < other.Radius) return -1;
            else return 0;
        }
    }

    // Chương trình kiểm thử
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo mảng ComparableCircle
            ComparableCircle[] circles = new ComparableCircle[3];
            circles[0] = new ComparableCircle(3.6, "red", true);
            circles[1] = new ComparableCircle(1.0, "blue", false);
            circles[2] = new ComparableCircle(3.5, "green", true);

            // In ra mảng trước khi sắp xếp
            Console.WriteLine("Trước khi sắp xếp:");
            foreach (var circle in circles)
            {
                Console.WriteLine(circle);
            }

            // Sắp xếp mảng
            Array.Sort(circles);

            // In ra mảng sau khi sắp xếp
            Console.WriteLine("\nSau khi sắp xếp:");
            foreach (var circle in circles)
            {
                Console.WriteLine(circle);
            }
        }
    }
}
