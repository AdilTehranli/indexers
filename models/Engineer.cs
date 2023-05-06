namespace learn3.models;

public abstract  class Engineer
{
    public  int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Salary { get; set; }
    public abstract double YearlyEarn();
}
