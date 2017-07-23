using System;
using System.Reflection;
public class Calc
//Brian O'Briskie 
//HW project 1 Calc.cs
{
	public static void Main(string[] args)
	{
		Assembly a = Assembly.LoadFrom ("Calc.dll");
		Console.WriteLine("Classes and Methods in Calc.dll");
		foreach(Type t in a.GetTypes())
		{		
			Console.WriteLine("Class Name : " + t.Name);
			Console.WriteLine("Methods in " + t.Name + ":");
			foreach(MethodInfo method in t.GetMethods())
			{
				Console.WriteLine(method);
			}
			Console.WriteLine(" ");
		}
	string choicecalculator, simpcalc, complcalc;
	do
	{
		Console.WriteLine("Select 1 for simple calculator, 2 for complex calculator and 3 to quit");
		choicecalculator = Console.ReadLine();

		if (choicecalculator == "1")
		{
			Console.WriteLine("Simple Calculator was selected");

			Console.WriteLine("Select 1 for add, 2 for sub, 3 to mult and 4 to div");
			simpcalc = Console.ReadLine();
			int c,d;
			if (simpcalc == "1")
			{
				Console.WriteLine("enter in the first int:");
				string first = Console.ReadLine();
				Console.WriteLine("enter in the second int:");
				string second = Console.ReadLine();
				c =int.Parse(first);
				d =int.Parse(second);
				SimpleCalc myClassObj = new SimpleCalc();
   				Type myTypeObj = myClassObj.GetType();
   				MethodInfo myMethodInfo = myTypeObj.GetMethod("add");
				object[] mParam = new object[] {c, d};
				Console.Write("Result: " +  myMethodInfo.Invoke(myClassObj, mParam) + " \n");

			}
			if (simpcalc == "2")
			{
				Console.WriteLine("enter in the first int:");
				string first = Console.ReadLine();
				Console.WriteLine("enter in the second int:");
				string second = Console.ReadLine();
				c =int.Parse(first);
				d =int.Parse(second);
				SimpleCalc myClassObj = new SimpleCalc();
   				Type myTypeObj = myClassObj.GetType();
   				MethodInfo myMethodInfo = myTypeObj.GetMethod("sub");
				object[] mParam = new object[] {c, d};
				Console.Write("Result: " +  myMethodInfo.Invoke(myClassObj, mParam) + " \n");
			}

			if (simpcalc == "3")
			{
				Console.WriteLine("enter in the first int:");
				string first = Console.ReadLine();
				Console.WriteLine("enter in the second int:");
				string second = Console.ReadLine();
				c =int.Parse(first);
				d =int.Parse(second);
				SimpleCalc myClassObj = new SimpleCalc();
   				Type myTypeObj = myClassObj.GetType();
   				MethodInfo myMethodInfo = myTypeObj.GetMethod("mult");
				object[] mParam = new object[] {c, d};
				Console.Write("Result: " +  myMethodInfo.Invoke(myClassObj, mParam) + " \n");
			}
			if (simpcalc == "4")
			{
				double x,y;
				Console.WriteLine("enter in the first int:");
				string first = Console.ReadLine();
				Console.WriteLine("enter in the second int:");
				string second = Console.ReadLine();
				x =double.Parse(first);
				y =double.Parse(second);
				SimpleCalc myClassObj = new SimpleCalc();
   				Type myTypeObj = myClassObj.GetType();
   				MethodInfo myMethodInfo = myTypeObj.GetMethod("div");
				object[] mParam = new object[] {x, y};
				Console.Write("Result: " +  myMethodInfo.Invoke(myClassObj, mParam) + " \n");
			}

		}

		if (choicecalculator == "2")
		{
			Console.WriteLine("Complex Calculator was selected");

			Console.WriteLine("Select 1 for add, 2 for sub, 3 to mult and 4 to div");
			complcalc = Console.ReadLine();
			int c,d,e,f;
			if (complcalc == "1")
			{
				Console.WriteLine("enter in the first real int:");
				string firstreal = Console.ReadLine();
				Console.WriteLine("enter in the first imaginary int:");
				string firstim = Console.ReadLine();
				c =int.Parse(firstreal);
				d =int.Parse(firstim);

				Console.WriteLine("enter in the second real int:");
				string secondreal = Console.ReadLine();
				Console.WriteLine("enter in the second imaginary int:");
				string secondim = Console.ReadLine();
				e =int.Parse(secondreal);
				f =int.Parse(secondim);

				ComplexCalc myClassObj = new ComplexCalc();
   				Type myTypeObj = myClassObj.GetType();
   				MethodInfo myMethodInfo = myTypeObj.GetMethod("addreal");
				object[] mParam = new object[] {c, e};
				Console.Write("Real: " +  myMethodInfo.Invoke(myClassObj, mParam));

   				myMethodInfo = myTypeObj.GetMethod("addim");
				mParam = new object[] {d, f};
				Console.Write("im: " +  myMethodInfo.Invoke(myClassObj, mParam)+ " \n");
			}

			if (complcalc == "2")
			{
				Console.WriteLine("enter in the first real int:");
				string firstreal = Console.ReadLine();
				Console.WriteLine("enter in the first imaginary int:");
				string firstim = Console.ReadLine();
				c =int.Parse(firstreal);
				d =int.Parse(firstim);

				Console.WriteLine("enter in the second real int:");
				string secondreal = Console.ReadLine();
				Console.WriteLine("enter in the second imaginary int:");
				string secondim = Console.ReadLine();
				e =int.Parse(secondreal);
				f =int.Parse(secondim);

				ComplexCalc myClassObj = new ComplexCalc();
   				Type myTypeObj = myClassObj.GetType();
   				MethodInfo myMethodInfo = myTypeObj.GetMethod("subreal");
				object[] mParam = new object[] {c, e};
				Console.Write("Real: " +  myMethodInfo.Invoke(myClassObj, mParam));

   				myMethodInfo = myTypeObj.GetMethod("subim");
				mParam = new object[] {d, f};
				Console.Write("im: " +  myMethodInfo.Invoke(myClassObj, mParam)+ " \n");
			}

			if (complcalc == "3")
			{
				Console.WriteLine("enter in the first real int:");
				string firstreal = Console.ReadLine();
				Console.WriteLine("enter in the first imaginary int:");
				string firstim = Console.ReadLine();
				c =int.Parse(firstreal);
				d =int.Parse(firstim);

				Console.WriteLine("enter in the second real int:");
				string secondreal = Console.ReadLine();
				Console.WriteLine("enter in the second imaginary int:");
				string secondim = Console.ReadLine();
				e =int.Parse(secondreal);
				f =int.Parse(secondim);

				ComplexCalc myClassObj = new ComplexCalc();
   				Type myTypeObj = myClassObj.GetType();
   				MethodInfo myMethodInfo = myTypeObj.GetMethod("multreal");
				object[] mParam = new object[] {c, e};
				Console.Write("Real: " +  myMethodInfo.Invoke(myClassObj, mParam));

   				myMethodInfo = myTypeObj.GetMethod("multim");
				mParam = new object[] {d, f};
				Console.Write("im: " +  myMethodInfo.Invoke(myClassObj, mParam)+ " \n");
			}

			if (complcalc == "4")
			{
				double p,l,o,k;
				Console.WriteLine("enter in the first real int:");
				string firstreal = Console.ReadLine();
				Console.WriteLine("enter in the first imaginary int:");
				string firstim = Console.ReadLine();
				p =double.Parse(firstreal);
				l =double.Parse(firstim);

				Console.WriteLine("enter in the second real int:");
				string secondreal = Console.ReadLine();
				Console.WriteLine("enter in the second imaginary int:");
				string secondim = Console.ReadLine();
				o =int.Parse(secondreal);
				k =int.Parse(secondim);

				ComplexCalc myClassObj = new ComplexCalc();
   				Type myTypeObj = myClassObj.GetType();
   				MethodInfo myMethodInfo = myTypeObj.GetMethod("divreal");
				object[] mParam = new object[] {p, o};
				Console.Write("Real: " +  myMethodInfo.Invoke(myClassObj, mParam));

   				myMethodInfo = myTypeObj.GetMethod("divim");
				mParam = new object[] {l, k};
				Console.Write("im: " +  myMethodInfo.Invoke(myClassObj, mParam)+ " \n");
			}

		}

	}while(choicecalculator != "3");

	}
}