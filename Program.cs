class Program
{
    //constant variables
    const int Is_Part_time = 1;
    const int Is_Full_time = 2;
    const int Emp_rate_perhr = 20;
    const int Num_of_Working_day = 20;
    const int Max_Hrs_Permonth = 100;
    public static int computeEmpwage()
    {
        //variable
        int emphrs = 0, totalEmphrs = 0, totalworkingdays = 0;
        while(totalEmphrs <= Max_Hrs_Permonth && totalworkingdays < Num_of_Working_day)
        {
            totalworkingdays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            //cheking epolyee
            switch (empCheck)
            {
                case Is_Part_time:
                    emphrs = 4;
                    break;
                case Is_Full_time:
                    emphrs = 8;
                    break;
                default:
                    emphrs = 0;
                    break;
            }
            //calculating total empolyee hours
            totalEmphrs += emphrs;
            Console.WriteLine("Day : " + totalworkingdays + " Emp Hrs " + emphrs);
        }
        int totalEmpwage = totalEmphrs + Emp_rate_perhr;
        Console.WriteLine("Total Empwage : " + totalEmpwage);
        return totalEmpwage;
    }
    static void Main(string[] args)
    {
        //calling method
        computeEmpwage();
    }
}
