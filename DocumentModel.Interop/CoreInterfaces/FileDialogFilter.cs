
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a file filter in a FileDialog object.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilter?view=office-pia
/// </remarks>
public partial interface FileDialogFilter: InteropObject
{
  /// <summary>
  /// Gets the `Extensions` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilter.extensions?view=office-pia
  /// </remarks>
  public string Extensions { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilter.description?view=office-pia
  /// </remarks>
  public string Description { get; }
}
