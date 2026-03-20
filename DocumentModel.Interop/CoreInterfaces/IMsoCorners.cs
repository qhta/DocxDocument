
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents chart corners.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners?view=office-pia
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
