namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether to export the document with markup.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdexportitem?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdExportItem")]
public enum ExportItem
{
  /// <summary>
  /// Exports the document without markup.
  /// </summary>
  [InteropEnumValue("wdExportDocumentContent")]
  Content = 0,
  /// <summary>
  /// Exports the document with markup.
  /// </summary>
  [InteropEnumValue("wdExportDocumentWithMarkup")]
  WithMarkup = 7
}
