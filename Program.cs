int Is_Part_time = 1;
int Is_Full_time = 2;
int Emp_rate_perhr = 20;
int emphr = 0;
int empwage = 0;
//Random function to generate 0,1 
Random random = new Random();
int empcheck = random.Next(0, 2);
//checking empolyee fulltime or parttime 
if (empcheck == Is_Part_time)
{
    emphr = 4;
}
else if (empcheck == Is_Full_time)
{
    emphr = 8;
}
else
{
    emphr = 0;
}
//calculating empolyee wage per hour
empwage = emphr * Emp_rate_perhr;
Console.WriteLine("Emp wage: " + empwage);
