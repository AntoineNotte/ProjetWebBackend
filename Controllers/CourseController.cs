using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class CourseController : ControllerBase
{
    private static List<Course> Courses = new List<Course>
    {
        new Course("Web", "Web is fun", "Developer"),
        new Course("Security", "Security is important", "Admin"),
        new Course("Network", "Network connects the world", "Admin"),
        new Course("Database", "Database contains our data", "DBA"),
    };

    private readonly ILogger<CourseController> _logger;

    public CourseController(ILogger<CourseController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Course> Get()
    {
        return Courses;
    }

    [HttpGet("ByName")]
    public Course Get(string name)
    {
        return Courses.FirstOrDefault(x=>x.Name.ToLower()==name.ToLower());
    }

    [HttpPost]
    public void Post(Course course)
    {
        //TODO backend validation
        Courses.Add(course);
    }

    


}
