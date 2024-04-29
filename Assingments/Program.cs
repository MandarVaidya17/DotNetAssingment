using Assingments;
using Assingments.LabAssingments;
using System.Collections;

//main method os declare by default by program
//declare object


/*Employee emp=new Employee ();

emp.Assign();
emp.CalculateSalary();
string res=emp.Display();
Console.WriteLine (res);

Employee emp2 = new Employee ();
emp2.Accept(101, "Mandar", 20000, 540.87, 200);
emp2.CalculateSalary();
Console.WriteLine (emp2.Display());
*/

/*Student stud=new Student();
Console.WriteLine(stud.Display());

Student s1= new Student(101,"Mandar");
Console.WriteLine(s1.Display());
*/

/*DateDemo d=new DateDemo();
Console.WriteLine(d.Display());

DateDemo d2=new DateDemo(29,4,2007);
Console.WriteLine(d2.Display());


//working with property
//property initializer syntax
Product p=new Product();
p.Code = 101;
p.Name = "Pablo";
p.Price = 900.9;

//Console.WriteLine($"code={p.Code} name={p.Name},price={p.Price}");

Book b1 = new Book();
b1.Bid = 111;
b1.Title = "Alchemist";
b1.Author = "Paulo";
Console.WriteLine($"Book Id={b1.Bid} Book Name={b1.Title},Book Author={b1.Author}");


Book b2 = new Book { Bid = 222, Title = "Thinking fast", Author = "Danial" };
Console.WriteLine($"Book Id={b2.Bid} Book Name={b2.Title},Book Author={b2.Author}");*/

/*
  Employee1 emp=new Employee1(1,"Pablo",2000,2300,250);
emp.CalculateSalary();
Console.WriteLine(emp.Display());

Manager man=new Manager(101,"MAndar",3000,3400,322,400);
man.CalculateSalary();
Console.WriteLine(man.Display());

Employee1 e1 = new Manager(102, "Sangar", 2003, 4000, 600, 800);
e1.CalculateSalary();
Console.WriteLine(e1.Display());

//

Circle c1=new Circle(5);
c1.CalculateArea();
Console.WriteLine(c1.Print());

Rectangle r1 = new Rectangle(5,5);
r1.CalculateArea();
Console.WriteLine(r1.Print());


int[] arr1 = new int[] { 90, 89, 78, 54, 1 };
int[] arr2 = new int[3];

foreach(int item in arr1)
{
    Console.WriteLine(item);
}

Array.Sort(arr1);
Console.WriteLine("-----after sort-------");
foreach(int item in arr1)
{
    Console.WriteLine(item);
}

Array.Reverse(arr1);
Console.WriteLine("------After reverse-----");
foreach(int item in arr1)
{
    Console.WriteLine(item);
}
Array.Copy(arr1, 2, arr2, 0, 3);
Console.WriteLine("copy array");
    foreach(int item in arr2)
{
    Console.WriteLine(item);
}

Array.Clear(arr1,0,3);
Console.WriteLine("Clear array");
foreach (int item in arr1)
{
    Console.WriteLine(item);
}


String[] name = new string[] { "Pablo", "Mandar", "Pooja", "Sagar" };
string[] name1 = new string[3];
foreach (string n in name)
{
    Console.WriteLine(n);
}

Array.Sort(name);
Console.WriteLine("After sort");
foreach (string n in name)
{
    Console.WriteLine(n);
}

Array.Reverse(name);
Console.WriteLine("After reverse");
foreach (string n in name)
{
    Console.WriteLine(n);
}

Array.Copy(name, 1, name1, 0, 3);
Console.WriteLine("After copy");
foreach (string n in name1)
{
    Console.WriteLine(n);
}

int[,] arr=new int[2,3];
Console.WriteLine("Enter arr");
for(int i=0; i<arr.GetLength(0); i++)
{
    for(int j=0; j < arr.GetLength(1);j++)
    arr[i,j] = Convert.ToInt32(Console.ReadLine());
}

Hashtable h1 = new Hashtable();
h1.Add(99,"Pablo");
h1.Add(98, "Sandesh");
h1.Add(97, "Amar");

h1.Remove(97);

foreach(DictionaryEntry i in h1)
{
    Console.WriteLine($"{i.Key} =  {i.Value}");
}

Console.WriteLine("Sorted list");

SortedList sl= new SortedList();
sl.Add(99,"Pablo");
sl.Add(98, "Sandesh");
sl.Add(97, "Sanket");
sl.Add(94, "Pranay");


foreach(DictionaryEntry i in sl)
{
    Console.WriteLine($"{i.Key} =  {i.Value}");



Person p1= new Person();
try
{
    p1.AcceptName("");
}
catch(NameException e)
{
    Console.WriteLine(e.Message);
}

CalclulatorDemo c1=new CalclulatorDemo();
MyDelegate obj = new MyDelegate(c1.Add);
obj += new MyDelegate(c1.Sub);
obj += new MyDelegate(c1.Mul);
//remove method from invocation list
obj -= new MyDelegate(c1.Sub);

Delegate[] list=obj.GetInvocationList();


foreach(Delegate item in list)
{
    Console.WriteLine(item.Method);
    Console.WriteLine(item.DynamicInvoke(4, 3));
}


*/