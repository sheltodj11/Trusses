using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Trusses.Models;
using Trusses.Repositories;

namespace Trusses.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScriptsController : ControllerBase
    {
    private readonly IScriptRepository _scriptRepository;

    public ScriptsController(IScriptRepository scriptRepository)
    {
      _scriptRepository = scriptRepository;
    }

    // GET: api/scripts
    [HttpGet]
    public ActionResult<IEnumerable<Script>> GetScripts()
    {
      var scripts = _scriptRepository.GetAll();
      return Ok(scripts);
    }

    // GET: api/scripts/{id}
    [HttpGet("{id}")]
    public ActionResult<Script> GetScript(int id)
    {
      var script = _scriptRepository.GetById(id);
      if (script == null)
      {
        return NotFound();
      }
      return Ok(script);
    }

    // POST: api/scripts
    [HttpPost]
    public ActionResult<Script> CreateScript(Script script)
    {
      _scriptRepository.Create(script);
      return CreatedAtAction(nameof(GetScript), new { id = script.Id }, script);
    }

    // PUT: api/scripts/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateScript(int id, Script script)
    {
      if (id != script.Id)
      {
        return BadRequest();
      }

      _scriptRepository.Update(script);

      return NoContent();
    }

    // DELETE: api/scripts/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteScript(int id)
    {
      var script = _scriptRepository.GetById(id);
      if (script == null)
      {
        return NotFound();
      }

      _scriptRepository.Delete(script.Id);

      return NoContent();
    }
  }
}
