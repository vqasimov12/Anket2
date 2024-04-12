namespace Task2;
public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public DateTime Birthday { get; set; }
    public override string ToString()
    {
        return Name;
    }

}
