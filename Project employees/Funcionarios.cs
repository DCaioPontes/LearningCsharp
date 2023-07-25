namespace Base;

public class Funcionarios
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public double Salary { get; private set; }

    public Funcionarios(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }
    
    public void Upgrade (double porcent)
    {
        porcent /= 100;
        Salary += Salary * porcent;
    }

    public override string ToString()
    {
        return $"{Id}, {Name}, {Salary.ToString("F2")}";
    }
}