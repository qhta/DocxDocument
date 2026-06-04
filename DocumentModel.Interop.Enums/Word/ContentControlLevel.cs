namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent the possible levels for a content control, returned by the Level property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcontentcontrollevel?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdContentControlLevel")]
public enum ContentControlLevel
{
  /// <summary>
  /// Represents a content control that surrounds content within a single paragraph.
  /// </summary>
  [WordInteropEnumValue("wdContentControlLevelInline")]
  Inline = 0,
  /// <summary>
  /// Represents a content control that surrounds one or more complete paragraphs.
  /// </summary>
  [WordInteropEnumValue("wdContentControlLevelParagraph")]
  Paragraph = 1,
  /// <summary>
  /// Represents a content control that surrounds a table row.
  /// </summary>
  [WordInteropEnumValue("wdContentControlLevelRow")]
  Row = 2,
  /// <summary>
  /// Represents a content control that surrounds a table cell.
  /// </summary>
  [WordInteropEnumValue("wdContentControlLevelCell")]
  Cell = 3
}
