namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies format to use for exporting a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdexportformat?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdExportFormat")]
public enum ExportFormat
{
  /// <summary>
  /// Export document into PDF format.
  /// </summary>
  [InteropEnumValue("wdExportFormatPDF")]
  PDF = 17,
  /// <summary>
  /// Export document into XML Paper Specification (XPS) format.
  /// </summary>
  [InteropEnumValue("wdExportFormatXPS")]
  XPS = 18
}
