using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private static List<Student> Students = new List<Student>
    {
        new Student("Corentin", "Thirion,"),
        new Student("Audric", "Grow"),
    };

    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        return Students;
    }

    [HttpGet("ByName")]
    public Student Get(string name)
    {
        return Students.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
    }
    
    [HttpPost]
    public void Post(Student student)
    {
        //TODO backend validation
        Students.Add(student);
    }




}
