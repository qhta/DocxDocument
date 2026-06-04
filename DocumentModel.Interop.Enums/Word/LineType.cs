namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether a line is a line of text or a table row.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinetype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdLineType")]
public enum LineType
{
  /// <summary>
  /// A line of text in the body of the document.
  /// </summary>
  [WordInteropEnumValue("wdTextLine")]
  TextLine = 0,
  /// <summary>
  /// A table row.
  /// </summary>
  [WordInteropEnumValue("wdTableRow")]
  TableRow = 1
}
