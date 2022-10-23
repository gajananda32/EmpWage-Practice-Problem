//variables
const int Is_Part_time = 1;
const int Is_Full_time = 2;
int Emp_rate_perhr = 20;
int emphr = 0;
int empwage = 0;
//Random function to generate 0,1,2
Random random = new Random();
int empcheck = random.Next(0, 3);
//checking empolyee 
switch (empcheck)
{
    case Is_Part_time:
        emphr =4;
        break;
    case Is_Full_time:
        break;
    default:
        emphr = 0;
        break;

}
//calculating empwage
empwage = emphr * Emp_rate_perhr;
Console.WriteLine("Emp wage: " + empwage);
