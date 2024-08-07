using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private static List<User> Users = new List<User>
    {
        new User("Corentin", "Thirion,"),
        new User("Audric", "Grow"),
    };

    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<User> Get()
    {
        return Users;
    }

    [HttpGet("ByIdentifiant")]
    public User Get(string identifiant)
    {
        return Users.FirstOrDefault(x => x.Identifiant.ToLower() == identifiant.ToLower());
    }
  
    [HttpPost]
    public void Post(User user)
    {
        //TODO backend validation
        Users.Add(user);
    }




}
