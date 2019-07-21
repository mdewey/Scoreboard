using System.Collections.Generic;

namespace Scoreboard.Pages.Models
{
  public class CatData
  {
    public string Status { get; set; }
    public List<Cat> Data { get; set; } = new List<Cat>();
  }
}