namespace DocumentModel.Wordprocessing;

/// <summary>
/// Constants that represent the possible levels for a content control, returned by the Level property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcontentcontrollevel?view=office-pia` for Office interop details.
/// </remarks>
public enum ContentControlLevel
{
  /// <summary>
  /// Represents a content control that surrounds content within a single paragraph.
  /// </summary>
  Inline = 0,
  /// <summary>
  /// Represents a content control that surrounds one or more complete paragraphs.
  /// </summary>
  Paragraph = 1,
  /// <summary>
  /// Represents a content control that surrounds a table row.
  /// </summary>
  Row = 2,
  /// <summary>
  /// Represents a content control that surrounds a table cell.
  /// </summary>
  Cell = 3
}
