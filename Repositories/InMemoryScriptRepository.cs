using Trusses.Models;

namespace Trusses.Repositories{
      // Example implementation of IScriptRepository using in-memory storage
  public class InMemoryScriptRepository : IScriptRepository
  {
    private readonly List<Script> _scripts = new List<Script>();

    public IEnumerable<Script> GetAll() => _scripts;

    public Script GetById(int id) => _scripts.Find(script => script.Id == id);

    public void Create(Script script)
    {
      script.Id = _scripts.Count + 1; // Assign a new ID
      _scripts.Add(script);
    }

    public void Update(Script script)
    {
      var existingScript = _scripts.FindIndex(s => s.Id == script.Id);
      if (existingScript != -1)
      {
        _scripts[existingScript] = script;
      }
    }

    public void Delete(int id)
    {
      var existingScript = _scripts.Find(s => s.Id == id);
      if (existingScript != null)
      {
        _scripts.Remove(existingScript);
      }
    }
  }
}