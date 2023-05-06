namespace learn3.models;

public class Developer : Engineer
{
    public sealed override double YearlyEarn()
    {
        return Salary * 12;
    }
    
}
