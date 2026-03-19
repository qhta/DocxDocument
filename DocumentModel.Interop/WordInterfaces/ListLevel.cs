namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single list level, either the only level for a bulleted or numbered list or one of the nine levels of an outline numbered list.
/// </summary>
public partial interface ListLevel : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The number format.
  /// </summary>
  public string NumberFormat { get; set; }

  /// <summary>
  /// The trailing character.
  /// </summary>
  public WdTrailingCharacter TrailingCharacter { get; set; }

  /// <summary>
  /// The number style.
  /// </summary>
  public WdListNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// The number position.
  /// </summary>
  public float NumberPosition { get; set; }

  /// <summary>
  /// The alignment.
  /// </summary>
  public WdListLevelAlignment Alignment { get; set; }

  /// <summary>
  /// The text position.
  /// </summary>
  public float TextPosition { get; set; }

  /// <summary>
  /// The tab position.
  /// </summary>
  public float TabPosition { get; set; }

  /// <summary>
  /// The reset on higher old.
  /// </summary>
  public bool ResetOnHigherOld { get; set; }

  /// <summary>
  /// The start at.
  /// </summary>
  public int StartAt { get; set; }

  /// <summary>
  /// The linked style.
  /// </summary>
  public string LinkedStyle { get; set; }

  /// <summary>
  /// The font.
  /// </summary>
  public Font Font { get; set; }

  /// <summary>
  /// The reset on higher.
  /// </summary>
  public int ResetOnHigher { get; set; }

  /// <summary>
  /// The picture bullet.
  /// </summary>
  public InlineShape PictureBullet { get; }
}
