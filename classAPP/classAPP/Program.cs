namespace classAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person(); //1. 객체를 생성
            Student student = new Student();
            student.stuby();
            student.eat();
            //person.age = 20;
            //person.eat(); //참조

            Console.WriteLine("Hello, World!");
        }
    }
    public class Person
    {
        private int age;
        public Person()
        {
            age = 30;
            Console.WriteLine("내 나이는" + age + "입니다 !");
        }//생성자
        ~Person()
        {

        }//소멸자

        public void eat()
        {
            Console.WriteLine("아침을 먹는다 !");
        }
    }
    public class Student : Person
    {
        int time;
        public Student()
        {
            time = 3; 
        }
        public void stuby()
        {
            Console.WriteLine("공부시간은" + time + "입니다 !");
        }
    }
}
