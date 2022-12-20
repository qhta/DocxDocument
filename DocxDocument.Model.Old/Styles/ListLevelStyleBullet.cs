namespace DocxDocument.Model;

public class ListLevelStyleBullet: ListLevelStyleText
{
  public string? BulletChar { get; set; }

  /// <summary>
  /// Percentage value for the bullet size relative to the font size of the paragraphs in the bullet list.
  /// </summary>
  public int? BulletRelativeSize { get; set; }
}