//variables
int IS_Full_Time = 1;
//random Function to generate values
Random random = new Random();
int empCheck = random.Next(0, 2);
int emphr = 0;
int empwg = 0;
int emprate_per_hr = 20;
//Cheking emp
if (empCheck == IS_Full_Time)

{
   emphr=8;

}
else
{
    emphr = 0;
}
empwg = emphr * emprate_per_hr;
Console.WriteLine("empwage : " + empwg);
