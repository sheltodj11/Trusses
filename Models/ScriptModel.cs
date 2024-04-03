namespace Trusses.Models{
      // Define the Script model
    public class Script
    {
      public int Id { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public string OwningApp { get; set; }
      public List<Step> Steps { get; set; }
      public List<Note> Notes { get; set; }
    }
}