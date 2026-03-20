
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartArtLayout` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartlayout?view=office-pia
/// </remarks>
public partial interface SmartArtLayout: InteropObject
{
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartlayout.id?view=office-pia
  /// </remarks>
  public string Id { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartlayout.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartlayout.description?view=office-pia
  /// </remarks>
  public string Description { get; }
  /// <summary>
  /// Gets the `Category` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartlayout.category?view=office-pia
  /// </remarks>
  public string Category { get; }
}
