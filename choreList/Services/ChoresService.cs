using System.Data.Common;
using choreList.Models;

namespace choreList.Services;

public class ChoresService
{
  private readonly ChoresRepository _repo;
  public ChoresService(ChoresRepository repo)
  {
    _repo = repo;
  }

  internal List<Chore> GetChores()
  {
    List<Chore> Chores = _repo.GetChores();
    return Chores;
  }

  internal Chore GetChoreById(int choreId)
  {
    Chore chore = _repo.GetChoreById(choreId);
    if (chore == null) throw new Exception($"no chore with the ID {choreId}");
    return chore;
  }

  internal Chore CreateChore(Chore choreData)
  {
    Chore chore = _repo.CreateChore(choreData);
    return chore;
  }

  internal string DeleteChore(int choreId)
  {
    Chore chore = this.GetChoreById(choreId);
    _repo.RemoveChore(choreId);
    return $"{chore.Name} has been deleted forever";
  }
}