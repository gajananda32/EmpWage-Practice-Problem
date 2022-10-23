//variable
int Is_Full_time = 1;
Random random = new Random();
int empCheck=random.Next(0,2);
if (empCheck == Is_Full_time) // check for fulltime empolyee
{
    Console.WriteLine("Empolyee is present");
}
else
{
    Console.WriteLine("Empolyee is absent");
}
