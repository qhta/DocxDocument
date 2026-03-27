
namespace DocumentModel.Drawings;

/// <summary>
/// Specifies view to use for a file find process.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilefindview?view=office-pia` for Office interop details.
/// </remarks>
public enum FileFindView
{
  /// <summary>
  /// View file information.
  /// </summary>
  FileInfo = 1,
  /// <summary>
  /// View preview of file.
  /// </summary>
  Preview,
  /// <summary>
  /// View summary information.
  /// </summary>
  SummaryInfo
}
