namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies format to use for exporting a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdexportformat?view=office-pia` for Office interop details.
/// </remarks>
public enum WdExportFormat
{
  /// <summary>
  /// Export document into PDF format.
  /// </summary>
  PDF = 17,
  /// <summary>
  /// Export document into XML Paper Specification (XPS) format.
  /// </summary>
  XPS = 18
}
