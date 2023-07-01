class A { public virtual void m() { Console.Write("A"); } }
class B : A { public override void m() { Console.Write("B"); } }
class C : B { new public virtual void m() { Console.Write("C"); } }
class D : C {public override void m() { Console.Write("D"); } }

public static class Program
{
  public static void Main()
  {
    D d = new D();
    A a = d; a.m();
    B b = d; b.m();
  }

}
