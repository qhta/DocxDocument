namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how much of the document to export.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdexportrange?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdExportRange))]
public enum ExportRange
{
  /// <summary>
  /// Exports the entire document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdExportRange.wdExportAllDocument))]
  AllDocument = 0,
  /// <summary>
  /// Exports the contents of the current selection.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdExportRange.wdExportSelection))]
  Selection = 1,
  /// <summary>
  /// Exports the current page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdExportRange.wdExportCurrentPage))]
  CurrentPage = 2,
  /// <summary>
  /// Exports the contents of a range using the starting and ending positions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdExportRange.wdExportFromTo))]
  FromTo = 3
}
