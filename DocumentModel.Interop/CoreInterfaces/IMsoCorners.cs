
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoCorners` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoCorners
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners.name?view=office-pia
  /// </remarks>
  public string Name { get; }
}
