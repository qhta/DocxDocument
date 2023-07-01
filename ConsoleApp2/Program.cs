namespace ConsoleApp2;

struct Point{
  public int x,y;
  public Point(int x, int y)
  {
    this.x = x;
    this.y = y;
  }
}
internal class Program
{
  static void Main(string[] args)
  {
    Point A = new Point(1, 1);
    Point B = A;
    B.x = 2;
    B.y = A.x*2;
    A.y = A.y*2;
    Console.WriteLine("{0}, {1}", A.x, A.y);
  }
}
