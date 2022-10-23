class Program
{
    //constant variables
    public const int IS_FULL_TIME = 1;
    public const int IS_PART_TIME = 2;
    static int computeEmpwage(string Company, int empRatePerhour, int numOfWorkingDay, int maxhrspermonth)
    {
        int emphrs = 0;
        int totalemphrs = 0;
        int totalworkingdays = 0;
        //checking the condistion
        while (totalemphrs <= maxhrspermonth && totalworkingdays < numOfWorkingDay)
        {
            totalworkingdays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            // check the empolyee 
            switch (empCheck)
            {
                case IS_PART_TIME:
                    emphrs = 4;
                    break;
                case IS_FULL_TIME:
                    emphrs = 8;
                    break;
                default:
                    emphrs = 0;
                    break;
            }
            totalemphrs += emphrs;
            Console.WriteLine("Day : " + totalworkingdays + " Emp Hrs " + emphrs);
        }
        int totalEmpwage = totalemphrs + empRatePerhour;
        Console.WriteLine("Total Empwage for company : " + Company + " is: " + totalEmpwage);
        return totalEmpwage;
    }
    static void Main(string[] args)
    {
        computeEmpwage("Apple", 40, 20, 100);
        computeEmpwage("Dell", 30, 20, 80);
    }
}
