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
  /// Specifies format to use for exporting a document.
  /// </summary>
  PDF = 17,
  /// <summary>
  /// Specifies format to use for exporting a document.
  /// </summary>
  XPS = 18
}
