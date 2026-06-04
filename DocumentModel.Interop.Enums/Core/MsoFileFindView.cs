
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies view to use for a file find process.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilefindview?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoFileFindView))]
public enum FileFindView
{
  /// <summary>
  /// View file information.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindView.msoViewFileInfo))]
  FileInfo = 1,
  /// <summary>
  /// View preview of file.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindView.msoViewPreview))]
  Preview,
  /// <summary>
  /// View summary information.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindView.msoViewSummaryInfo))]
  SummaryInfo
}
