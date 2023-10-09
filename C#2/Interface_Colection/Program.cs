using System;
using System.Collections;
public class Employee : IComparable
{
    private int id;
    public Employee(int id)
    {
        this.id = id;
    }
    public override string ToString()
    {
        return id.ToString();
    }
    public int Id
    {
        get { return id; }
        set { this.id = value; }
    }
    public int CompareTo(object o)
    {
        Employee r = (Employee)o;
        return this.id.CompareTo(r.id); 
    }
}
public class Program
{
    static void Main()
    {
        ArrayList arr = new ArrayList();
        Random r = new Random();
        for(int i = 0; i < 5; i++)
        {
            arr.Add(new Employee(r.Next(10) + 100));
        }
        for(int i = 0; i < arr.Count;i++)
        {
            Console.Write("{0}", arr[i].ToString());
        }
        Console.WriteLine("\n");
        arr.Sort();
        for(int i = 0; i<arr.Count;i++)
        {
            Console.Write("{0}", arr[i].ToString());
        }
        Console.WriteLine("\n");
    }
}