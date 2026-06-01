
namespace DocumentModel.IApplication;

/// <summary>
/// Specifies view Ito use Ifor a file find process.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilefindview?view=office-pia` Ifor Office interop details.
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

