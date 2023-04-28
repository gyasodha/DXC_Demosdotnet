using System;

interface Vehicle
{
    void Drivetest();
    bool Refuel(int amount);
}

class Car : Vehicle
{
    public int gasoline;

    public Car(int initialGasoline)
    {
        gasoline = initialGasoline;
    }

    public void Drivetest()
    {
        if (gasoline > 0)
        {
            Console.WriteLine("The car is driving.....");
        }
        else
        {
            Console.WriteLine("The car is not driving.......");
        }
    }

    public bool Refuel(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("It is INVALID Amount");
            return false;
        }
        gasoline += amount;
        Console.WriteLine("Gasoline refueled.... Current gasoline level: " + gasoline);
        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the amount of gasoline to refuel: ");
        int amount = int.Parse(Console.ReadLine());
        Car car = new Car(0);
        car.Refuel(amount);
        car.Drivetest();
    }
}