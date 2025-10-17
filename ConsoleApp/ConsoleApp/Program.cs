using System;
class Program
{
    public static void Main(string[] args)
    {
        var venturan = new Student("张三", 23,1,3,2);
        Console.WriteLine(venturan.personIsAdult());
    }
}

class Person
{
    protected string name;
    protected int age = 0;
    protected int sex;
    protected bool isAdult = false;
    public Person() {
        Console.WriteLine(this.age);
        if (this.age >= 18)
        {
            this.isAdult = true;
        }else
        {
            this.isAdult = false;
        }
    }
    public bool personIsAdult()
    {
        return this.isAdult;
    }
}

class Student : Person
{
    public int grade;
    public int classes;

    public Student(string name, int age,int sex, int grade, int classes):base()
    {
       this.grade = grade;
       this.classes = classes;
       base.name = name;
       base.age = age;
       base.sex = sex;
    }
}