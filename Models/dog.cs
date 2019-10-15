using System;
using System.ComponentModel.DataAnnotations;

namespace Dogs.Models
{

  public class dog
  {
    public dog()
    {
      this.Id = String.Join("", Guid.NewGuid().ToString().Split('-'));
    }
    public dog(string name, string color, int age)
    {
      this.Name = name;
      this.Color = color;
      this.Age = Age;
      this.Id = String.Join("", Guid.NewGuid().ToString().Split('-'));
    }
    public dog(string name, string color, int age, string id)
    {
      this.Name = name;
      this.Color = color;
      this.Age = age;
      this.Id = id;

    }
    public string Name { get; set; }

    public string Color { get; set; }

    public int Age { get; set; }

    public string Id { get; set; }
  }
}

