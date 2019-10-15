using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dogs.Models;

namespace Dogs.DB
{

  public static class FakeDB
  {
    public static List<dog> Dogs = new List<dog>()
    {
  new dog("A", "black", 1),
  new dog("b", "grey", 2),
  new dog("C", "brown", 3)
    };
  }
}


