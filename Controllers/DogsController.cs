using System;
using System.Collections.Generic;
using Dogs.DB;
using Dogs.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiDogs.Controllers
{
  [ApiController]
  [Route("Api/[Controller]")]

  public class DogsController : ControllerBase
  {

    public List<dog> Dogs { get; set; } = FakeDB.Dogs;

    [HttpGet]

    public ActionResult<IEnumerable<dog>> Get() 
    {
      return Ok(Dogs); 
    }

    [HttpGet("{id}")]

    public ActionResult<dog> GetAction(string id)
    {
      try 
      {
        dog d = Dogs.Find(dog => dog.Id == id);
        if (d == null) { throw new Exception("Invalid Id"); }
        return Ok(d); 
      }
      catch (Exception e)
      {
        return BadRequest(e.Message); 
      }
    }

    [HttpGet("{index}/index")] 

    public ActionResult<dog> Get(int index)
    {
try
{
        dog d = Dogs[index];
        return Ok(d); 
      }
      catch (Exception e)
      {
        return BadRequest(e.Message); 
      }
    }
  }
}