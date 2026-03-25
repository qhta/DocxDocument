
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents chart corners.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners?view=office-pia"/>
public partial interface IMsoCorners: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners.name?view=office-pia"/>
  public string Name { get; }
}

