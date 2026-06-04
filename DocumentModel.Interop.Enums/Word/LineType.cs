namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether a line is a line of text or a table row.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinetype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdLineType")]
public enum LineType
{
  /// <summary>
  /// A line of text in the body of the document.
  /// </summary>
  [InteropEnumValue("wdTextLine")]
  TextLine = 0,
  /// <summary>
  /// A table row.
  /// </summary>
  [InteropEnumValue("wdTableRow")]
  TableRow = 1
}
