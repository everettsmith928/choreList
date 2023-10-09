using System.Data.Common;

namespace choreList.Repositories;

public class ChoresRepository
{
  private List<Chore> _FakeDb;

  public ChoresRepository()
  {
    _FakeDb = new List<Chore>();
    _FakeDb.Add(new Chore(1, "Dishes", "Wash all the dishes", 1, false));
    _FakeDb.Add(new Chore(2, "Laundry", "Clean all of the Laundry", 2, false));
    _FakeDb.Add(new Chore(3, "Resume", "Touch up your resume", 3, false));
    _FakeDb.Add(new Chore(4, "Dinner", "Cook dinner and lunch for tomorrow", 1, false));
    _FakeDb.Add(new Chore(5, "Reading", "Readings for the week", 1, false));
  }

  internal List<Chore> GetChores()
  {
    return _FakeDb;
  }

  internal Chore GetChoreById(int choreId)
  {
    Chore chore = _FakeDb.Find(c => c.Id == choreId);
    return chore;
  }

  internal Chore CreateChore(Chore choreData)
  {
    int choreId = _FakeDb[_FakeDb.Count - 1].Id;
    choreData.Id = choreId + 1;
    _FakeDb.Add(choreData);
    return choreData;
  }

  internal void RemoveChore(int choreId)
  {
    Chore chore = _FakeDb.Find(c => c.Id == choreId);
    _FakeDb.Remove(chore);
  }

}