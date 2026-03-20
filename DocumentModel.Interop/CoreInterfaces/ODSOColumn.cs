
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a field in a data source.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumn?view=office-pia
/// </remarks>
public partial interface ODSOColumn: InteropObject
{
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumn.index?view=office-pia
  /// </remarks>
  public int Index { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumn.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Value` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumn.value?view=office-pia
  /// </remarks>
  public string Value { get; }
}
