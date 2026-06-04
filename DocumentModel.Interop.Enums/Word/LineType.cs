namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether a line is a line of text or a table row.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinetype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdLineType))]
public enum LineType
{
  /// <summary>
  /// A line of text in the body of the document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineType.wdTextLine))]
  TextLine = 0,
  /// <summary>
  /// A table row.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineType.wdTableRow))]
  TableRow = 1
}
