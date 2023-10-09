namespace choreList.Models;
public class Chore
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public int Priority { get; set; }
  public bool Done { get; set; }
  public Chore(int id, string name, string description, int priority, bool done)
  {
    Id = id;
    Name = name;
    Description = description;
    Priority = priority;
    Done = done;
  }
}