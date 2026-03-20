
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartArtColor` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartcolor?view=office-pia
/// </remarks>
public partial interface SmartArtColor: InteropObject
{
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartcolor.id?view=office-pia
  /// </remarks>
  public string Id { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartcolor.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartcolor.description?view=office-pia
  /// </remarks>
  public string Description { get; }
  /// <summary>
  /// Gets the `Category` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartcolor.category?view=office-pia
  /// </remarks>
  public string Category { get; }
}
