namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent the possible levels for a content control, returned by the Level property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcontentcontrollevel?view=office-pia` for Office interop details.
/// </remarks>
public enum WdContentControlLevel
{
  /// <summary>
  /// Constants that represent the possible levels for a content control, returned by the Level property.
  /// </summary>
  Inline = 0,
  /// <summary>
  /// Constants that represent the possible levels for a content control, returned by the Level property.
  /// </summary>
  Paragraph = 1,
  /// <summary>
  /// Represents a content control that surrounds a table row. wdContentControlLevelCell3 Represents a content
  /// control that surrounds a table cell.
  /// </summary>
  Row = 2,
  /// <summary>
  /// Constants that represent the possible levels for a content control, returned by the Level property.
  /// </summary>
  Cell = 3
}
