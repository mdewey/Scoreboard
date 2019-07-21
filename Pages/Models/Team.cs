namespace Scoreboard.Pages.Models
{
  public class Team
  {
    public int Score { get; set; }
    public string Name { get; set; }

    public void UpdateScore()
    {
      this.Score++;
      //   return true;
    }
    public bool UpdateScore(int value)
    {
      this.Score += value;
      return true;
    }
  }

}