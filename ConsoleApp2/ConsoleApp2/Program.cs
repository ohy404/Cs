using System;

class Robot
{
    public void Move()
    {
        Console.WriteLine("로봇이 움직입니다.");
    }
}
class CleanRobot : Robot //클래스 상속
{
    public void Clean()
    {
        Console.WriteLine("청소를 시작합니다.");
    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        CleanRobot cleanRobot = new CleanRobot();
        cleanRobot.Move(); //클린로봇에 없는 메소드지만 상속 받은 로봇 클래스에서 받아 씀
        cleanRobot.Clean(); //공개된 cleanrobot 클래스에서 쓰인 메소드를 직접 씀
    }
}