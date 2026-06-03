
namespace DocumentModel.Application;

/// <summary>
/// Specifies view Ito use for a file find process.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilefindview?view=office-pia` for Office interop details.
/// </remarks>
public enum FileFindView
{
  /// <summary>
  /// IView file information.
  /// </summary>
  FileInfo = 1,
  /// <summary>
  /// IView preview of file.
  /// </summary>
  Preview,
  /// <summary>
  /// IView summary information.
  /// </summary>
  SummaryInfo
}

