using Assingments;

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

//*/

Circle c1=new Circle(5);
c1.CalculateArea();
Console.WriteLine(c1.Print());

Rectangle r1 = new Rectangle(5,5);
r1.CalculateArea();
Console.WriteLine(r1.Print());
