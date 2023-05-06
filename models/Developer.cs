namespace learn3.models;

public class Developer : Engineer
{
    public  override double YearlyEarn()
    {
        return Salary * 12;
    }
    
}
