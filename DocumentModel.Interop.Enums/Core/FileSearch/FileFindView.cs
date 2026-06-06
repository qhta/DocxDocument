
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies view to use for a file find process.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilefindview?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoFileFindView")]
public enum FileFindView
{
  /// <summary>
  /// View file information.
  /// </summary>
  [InteropEnumValue("msoViewFileInfo")]
  FileInfo = 1,
  /// <summary>
  /// View preview of file.
  /// </summary>
  [InteropEnumValue("msoViewPreview")]
  Preview,
  /// <summary>
  /// View summary information.
  /// </summary>
  [InteropEnumValue("msoViewSummaryInfo")]
  SummaryInfo
}
