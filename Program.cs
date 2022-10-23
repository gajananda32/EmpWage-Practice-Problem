// constant varibles
public const int Is_Part_time = 1;
public const int Is_Full_time = 2;
const int Emp_rate_perhr = 20;
const int Num_of_Working_day = 20;
int emphr = 0;
int empwage = 0;
int totalempwage = 0;
for (int day = 0; day < Num_of_Working_day; day++)
{
    Random random = new Random();
    int empcheck = random.Next(0, 3);
    //checking for empolyeement
    switch (empcheck)
    {
        case Is_Part_time:
            emphr = 4;
            break;
        case Is_Full_time:
            emphr = 8;
            break;
        default:
            emphr = 0;
            break;

    }
    //calculating employee wage
    empwage = emphr * Emp_rate_perhr;
    totalempwage += empwage;
    Console.WriteLine("Emp wage: " + empwage);
}
Console.WriteLine("total emp wage: " + totalempwage);
