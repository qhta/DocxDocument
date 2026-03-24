namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent the possible levels for a content control, returned by the Level property.
/// </summary>
public enum WdContentControlLevel
{
  /// <summary>
  /// Constants that represent the possible levels for a content control, returned by the Level property.
  /// </summary>
  Inline = unchecked((int)0),
  /// <summary>
  /// Constants that represent the possible levels for a content control, returned by the Level property.
  /// </summary>
  Paragraph = unchecked((int)1),
  /// <summary>
  /// Represents a content control that surrounds a table row. wdContentControlLevelCell3 Represents a content
  /// control that surrounds a table cell.
  /// </summary>
  Row = unchecked((int)2),
  /// <summary>
  /// Constants that represent the possible levels for a content control, returned by the Level property.
  /// </summary>
  Cell = unchecked((int)3)
}
