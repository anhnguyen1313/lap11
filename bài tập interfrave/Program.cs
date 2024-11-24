using System;

// Lớp trừu tượng Animal
public abstract class Animal
{
    public abstract string MakeSound(); // Phương thức trừu tượng
}

// Lớp Tiger kế thừa Animal
public class Tiger : Animal
{
    public override string MakeSound()
    {
        return "Tiger: roarrrrr!";
    }
}

// Interface Edible
public interface Edible
{
    string HowToEat();
}

// Lớp Chicken kế thừa Animal và triển khai Edible
public class Chicken : Animal, Edible
{
    public override string MakeSound()
    {
        return "Chicken: cluck-cluck!";
    }

    public string HowToEat()
    {
        return "could be fried";
    }
}

// Lớp trừu tượng Fruit
public abstract class Fruit : Edible
{
    public abstract string HowToEat(); // Phương thức trừu tượng
}

// Lớp Apple kế thừa Fruit
public class Apple : Fruit
{
    public override string HowToEat()
    {
        return "Apple could be sliced";
    }
}

// Lớp Orange kế thừa Fruit
public class Orange : Fruit
{
    public override string HowToEat()
    {
        return "Orange could be juiced";
    }
}

// Chương trình kiểm thử
class Program
{
    static void Main(string[] args)
    {
        // Tạo mảng động vật
        Animal[] animals = new Animal[2];
        animals[0] = new Tiger();   // Thêm Tiger vào mảng
        animals[1] = new Chicken(); // Thêm Chicken vào mảng

        // Duyệt qua mảng và gọi MakeSound
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.MakeSound());

            // Kiểm tra xem animal có triển khai Edible không
            if (animal is Edible edibler)
            {
                Console.WriteLine(edibler.HowToEat());
            }
        }

        Console.WriteLine("----------------------");

        // Tạo mảng trái cây
        Fruit[] fruits = new Fruit[2];
        fruits[0] = new Orange(); // Thêm Orange vào mảng
        fruits[1] = new Apple();  // Thêm Apple vào mảng

        // Duyệt qua mảng và gọi HowToEat
        foreach (Fruit fruit in fruits)
        {
            Console.WriteLine(fruit.HowToEat());
        }
    }
}

