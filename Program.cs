public class EmpWAgeBuilderArray
{
    //constant variables
    public const int IS_FULL_TIME = 1;
    public const int IS_PART_TIME = 2;
    private int numofcomapny = 0;
    private companyEmpWage[] companyEmpWageArray;
    //creating method
    public EmpWAgeBuilderArray()
    {
        //adding max element five
        this.companyEmpWageArray = new companyEmpWage[5];
    }
   public void addcomapnyEmpWage(string company, int empRatePerhour, int numOfWorkingDay, int maxhrspermonth)
    {
        companyEmpWageArray[this.numofcomapny] = new companyEmpWage(company, empRatePerhour, numOfWorkingDay, maxhrspermonth);
        numofcomapny++;
    }
    public void computeEmpWage()
    {
        for(int i=0; i < numofcomapny; i++)
        {
            //calling method
            companyEmpWageArray[i].setTotalEmpwage(this.computeEmpWage(this.companyEmpWageArray[i]));
            Console.WriteLine(this.companyEmpWageArray[i].toString());
        }
    }
    private int computeEmpWage(companyEmpWage companyEmpWage)
    {
        int emphrs = 0;
        int totalemphrs = 0;
        int totalworkingdays = 0;
        while (totalemphrs <= companyEmpWage.maxhrspermonth && totalworkingdays < this.numOfWorkingDay)
        {
            totalworkingdays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            // checking for empolyee
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
        return totalemphrs * companyEmpWage.empRatePerhour;
    }
}
public class companyEmpWage
{

    private string company;
    private int empRatePerhour;
    private int numOfWorkingDay;
    private int maxhrspermonth;
    private int totalEmpWage;
    public companyEmpWage(string company, int empRatePerhour, int numOfWorkingDay, int maxhrspermonth)
    {
        this.company = company;
        this.empRatePerhour = empRatePerhour;
        this.numOfWorkingDay = numOfWorkingDay;
        this.maxhrspermonth = maxhrspermonth;
    }
    public void setTotalEmpwage(int totalEmpwage)
    {
        this.totalEmpWage = totalEmpWage;
    }
    public string toString()
    {
        return "Total Emp Wage for company : " + this.company + " is: " + this.totalEmpWage;
    }
}
class Program
{
    static void Main(string[] args)
    {
        EmpWAgeBuilderArray empWAgeBuilder = new EmpWAgeBuilderArray();
        empWAgeBuilder.addcomapnyEmpWage("Apple", 40, 4, 200);
        empWAgeBuilder.addcomapnyEmpWage("Meta", 30, 5, 100);
        empWAgeBuilder.computeEmpWage();
    }
}
