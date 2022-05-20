namespace Prn.Se1624;

public class  Emp
{
    // define fields(data)
    private int _id;
    private string _name;
    private DateOnly _dob;

    // define  properties 
    public float Salary { get; set; }
    public string Level { get; set; }
    public int Id { get => _id; set => _id = value; }
    public int Name { get => _name; set => _name = value; }
    public DateOnly Dob { get => _dob; set => _dob = value; }

    //constructrors
    public Emp()
    {

    }

    public Emp(float salary, string level, int id, int name, DateOnly dob)
    {
        Salary = salary;
        Level = level;
        Id = id;
        Name = name;
        Dob = dob;
    }
    // manual methods
    public override string? ToString()
    {
        return GetString();
    }
    public GetString()
    {
        return $"[Id = {this._id}, Name = {Name}, Dob = {this._dob}],Level ={Level}, Salary = {Salary}";
    }

}