
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a file filter in a FileDialog object.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilter?view=office-pia"/>
public partial class FileDialogFilter: InteropObject
{
  /// <summary>
  /// Gets the `Extensions` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilter.extensions?view=office-pia"/>
  public string Extensions { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilter.description?view=office-pia"/>
  public string Description { get; }
}

