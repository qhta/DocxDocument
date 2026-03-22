namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent the possible levels for a content control, returned by the Level property.
/// </summary>
public enum WdContentControlLevel
{
  /// <summary>
  /// Constants that represent the possible levels for a content control, returned by the Level property.
  /// </summary>
  wdContentControlLevelInline = unchecked((int)0),
  /// <summary>
  /// Constants that represent the possible levels for a content control, returned by the Level property.
  /// </summary>
  wdContentControlLevelParagraph = unchecked((int)1),
  /// <summary>
  /// Represents a content control that surrounds a table row. wdContentControlLevelCell3 Represents a content
  /// control that surrounds a table cell.
  /// </summary>
  wdContentControlLevelRow = unchecked((int)2),
  /// <summary>
  /// Constants that represent the possible levels for a content control, returned by the Level property.
  /// </summary>
  wdContentControlLevelCell = unchecked((int)3)
}
