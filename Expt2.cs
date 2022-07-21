using System;
class Expt2
  {
   public sealed class Sl
	{
	public void fun()
	  {
	  Console.WriteLine("This is Sealed class and cannot be inherited");
	  }
		int x;
		}
  public abstract class S2
		{
		int f;
	public void method()
	 {
	Console.WriteLine("This is method in abstract class");
	}
   }
	public class Derived : S2
		{
		}
	static class St_demo
		{
		public static void show()
			{
			Console.WriteLine("This is static class method , called without creating instance of class");
			}
		}
	public class Base1
		{
		public void function()
			{
			Console.WriteLine("Function in Base class called.");
			}
		}
	class Derived1 : Base1
		{
		public void function_d()
			{
			Console.WriteLine("function in Derived class is called.");
			}
		}
	public static void initialize(out int i)
		{
		i=45;
		}
	static void swap(ref int a, ref int b)
		{
		int temp;
		temp=a;
		a=b;
		b=temp;
		}
	void fun(int a)
		{
		Console.WriteLine("Function with 1 paramter is called");
		}
	void fun(int a,int b)
		{
		Console.WriteLine("Function with 2 paramter is called");	
		}
	void fun(int a,int b, int c)
		{
		Console.WriteLine("Function with 3 paramter is called");	
		}
	public static void Main(String[] args)
		{
		int a,cn;
		Expt2 x=new Expt2();
		do
			{
			Console.WriteLine("Choose Option:\n 1.Classes\n 2.Outdemo \n 3.Inheritance\n 4.Reference_demo\n 5.Overload");
			a=Convert.ToInt32(Console.ReadLine());
			switch(a)
				{
				case 1:
					Sl_demo s=new Sl_demo();
					Derived d=new Derived();
					s.fun();
					d.method();
					St_demo.show();
					break;
				case 2:
					int i;
					initialize(out i);
					Console.WriteLine("Inialized value of i is {0}",i);					
					break;
				case 3:
					Derived1 m=new Derived1();
					m.function();
					m.function_d();					
					break;
				case 4:
					int l=12,y=20;
					swap(ref l,ref y);
					Console.WriteLine("Value of l:"+l);
					Console.WriteLine("Value of y:"+y);
					break;
				case 5:
					Expt2 p=new Expt2();
					p.fun(1);
					p.fun(1,2);
					p.fun(1,2,3);		
					break;
				default:
					Console.WriteLine("Invalid option");
					break;
				}
			Console.WriteLine("Do you want to continue 1=yes 2=no");
			cn=Convert.ToInt32(Console.ReadLine());
			}while(cn==1);
		}

	}