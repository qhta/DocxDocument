namespace DocxDocument.Model;

public class ListStyle : Style
{
  //public string? Name { get; set; }
  public string? DisplayName { get; set; }

  public bool? ConsecutiveNumbering { get; set; }

  public List<ListLevelStyle> Levels { get; set; } = new List<ListLevelStyle>();
}