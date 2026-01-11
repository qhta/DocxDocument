namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a single list level in a list template.
/// </summary>
/// <remarks>
///   Each list template contains nine list levels (1-9), each with its own
///   number format, position, alignment, and other formatting attributes.
/// </remarks>
public interface ListLevel: CollectionItem
{
  #region Number Format

  /// <summary>
  ///   Gets or sets the number style for the list level.
  /// </summary>
  /// <remarks>
  ///   Specifies the numbering format (Arabic, Roman, letters, etc.).
  /// </remarks>
  public NumberFormatKind? NumberFormatType { get; set; }

  /// <summary>
  ///   Gets or sets the starting number for the list level.
  /// </summary>
  /// <remarks>
  ///   Default is 1. Can be set to any positive integer.
  /// </remarks>
  public int StartAt { get; set; }

  /// <summary>
  ///   Gets or sets the number style within the legal or simplified legal numbering scheme.
  /// </summary>
  public ListLevelNumberStyleKind? NumberStyle { get; set; }

  /// <summary>
  ///   Gets or sets the position for a specified list level.
  /// </summary>
  /// <remarks>
  ///   Specifies how the list level should be positioned relative to text.
  /// </remarks>
  public ListLevelPositionKind? NumberPositionType { get; set; }

  /// <summary>
  ///   Gets or sets the alignment for the numbers in the list level.
  /// </summary>
  public ListLevelAlignmentKind? Alignment { get; set; }

  /// <summary>
  ///   Gets or sets the text format for the list level.
  /// </summary>
  /// <remarks>
  ///   Includes placeholders for numbers from this and higher levels.
  ///   For example, "%1.%2." for 1.1, 1.2, etc.
  /// </remarks>
  public string? NumberFormat { get; set; }

  /// <summary>
  ///   Gets or sets whether to include trailing character after the number.
  /// </summary>
  public TrailingCharacterKind? TrailingCharacter { get; set; }

  #endregion

  #region Position and Indentation

  /// <summary>
  ///   Gets or sets the number position relative to the left margin.
  /// </summary>
  public float NumberPosition { get; set; }

  /// <summary>
  ///   Gets or sets the text indent relative to the number position.
  /// </summary>
  public float TextPosition { get; set; }

  /// <summary>
  ///   Gets or sets the tab position after the number.
  /// </summary>
  public float TabPosition { get; set; }

  /// <summary>
  ///   Gets or sets whether to reset the number when a higher level is encountered.
  /// </summary>
  public int? ResetOnHigher { get; set; }

  #endregion

  #region Font Formatting

  /// <summary>
  ///   Gets or sets the font applied to the list number.
  /// </summary>
  public TextFormat? Font { get; set; }

  /// <summary>
  ///   Gets or sets the linked paragraph style.
  /// </summary>
  public string? LinkedStyle { get; set; }

  #endregion

  #region Picture Bullet

  /// <summary>
  ///   Gets the picture bullet for the list level.
  /// </summary>
  public DMWD.InlineShape? PictureBullet { get; }

  /// <summary>
  ///   Applies a picture bullet to the list level.
  /// </summary>
  /// <param name="fileName">The path to the picture file.</param>
  public void ApplyPictureBullet(string fileName);

  #endregion

  #region Parent Properties

  /// <summary>
  ///   Gets the index of the list level (1-9).
  /// </summary>
  public int Index { get; }

  /// <summary>
  ///   Gets the parent list levels collection.
  /// </summary>
  public ListLevels? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}