namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a dropped capital letter at the beginning of a paragraph.
/// </summary>
public partial interface DropCap : InteropObject
{
  /// <summary>
  /// The position.
  /// </summary>
  public WdDropPosition Position { get; set; }

  /// <summary>
  /// The font name.
  /// </summary>
  public string FontName { get; set; }

  /// <summary>
  /// The lines to drop.
  /// </summary>
  public int LinesToDrop { get; set; }

  /// <summary>
  /// The distance from text.
  /// </summary>
  public float DistanceFromText { get; set; }
}
