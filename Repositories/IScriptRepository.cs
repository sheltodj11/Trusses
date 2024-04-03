using Trusses.Models;

namespace Trusses.Repositories{
  public interface IScriptRepository
  {
    IEnumerable<Script> GetAll();
    Script GetById(int id);
    void Create(Script script);
    void Update(Script script);
    void Delete(int id);
  }
}