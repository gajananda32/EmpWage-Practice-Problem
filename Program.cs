public class EmpWageBuilder : IComputeEmpWage
{
    public const int is_parttime = 1;
    public const int is_fulltime = 2;

    private LinkedList<companyEmpWage> companyEmpWageList;
    private Dictionary<string, companyEmpWage> companyToEmpWageMap;

    public EmpWageBuilder()
    {
        this.companyEmpWageList = new LinkedList<companyEmpWage>();
        this.companyToEmpWageMap = new Dictionary<string, companyEmpWage>(); 
    }
    public void addcompanyEmpWage(string company,int emprate,int numofWorkingdays,int maxhrspermonth)
    {
        companyEmpWage companyEmpWage = new companyEmpWage(company, emprate, numofWorkingdays, maxhrspermonth);
        this.companyEmpWageList.AddLast(companyEmpWage);
        this.companyToEmpWageMap.Add(company, companyEmpWage);
    }
    public void computeEmpWage()
    {
        foreach (companyEmpWage companyEmpWage  in this.companyEmpWageList)
        {
            companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
            Console.WriteLine(companyEmpWageList.ToString());
        }
    }
    private int computeEmpWage(companyEmpWage companyEmpWage);
        public int getTotalWage(string company)
        {
        return this.companyToEmpWageMap[company].totalEmpWage;
        }
}
class Program
{
    static void Main(string[] args)
    {
        EmpWageBuilder empWageBuilder = new EmpWageBuilder();
        empWageBuilder.addcompanyEmpWage("Apple", 40, 4, 100);
        empWageBuilder.addcompanyEmpWage("Meta", 40, 5, 80);
        empWageBuilder.computeEmpWage();
        Console.WriteLine("total wage for Apple company : " + empWageBuilder.getTotalWage("Apple"));

    }
}
public interface IComputeEmpWage
{
    public void addcompany(string company, int emprate, int numofWorkingdays, int maxhrspermonth);
    public void computeEmpWage();
    public int getTotalWage(string company);
}
public class companyEmpWage
{
    public string company;
    public int emprateperhr;
    public int numofWorkingdays;
    public int maxhrspermonth;
    public int totalEmpWage;
    public companyEmpWage(string company, int emprateperhr, int numofWorkingdays, int maxhrspermonth)
    {
        this.company = company;
        this.emprateperhr = emprateperhr;
        this.numofWorkingdays = numofWorkingdays;
        this.maxhrspermonth = maxhrspermonth;
        this.totalEmpWage = 0;
    }
    public void setTotalEmpWage(int totalEmpWage)
    {
        this.totalEmpWage = totalEmpWage;
    }
    public string toString()
    {
        return "total Emp Wage for comapany : " + this.company + " is " + this.totalEmpWage;
    }

}
