namespace backend.Models;

public class Course
{

    public Course(string name, string description, string type)
    {
        Name = name;
        Description = description;
        Type=type;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
}
