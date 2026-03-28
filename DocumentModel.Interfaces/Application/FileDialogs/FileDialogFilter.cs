
namespace DocumentModel.Application;

/// <summary>
/// Represents a file filter in a FileDialog object.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilter?view=office-pia"/>
public partial interface FileDialogFilter: InteropObject
{
  /// <summary>
  /// Gets the `Extensions` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilter.extensions?view=office-pia"/>
  public string Extensions { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilter.description?view=office-pia"/>
  public string Description { get; }
}

