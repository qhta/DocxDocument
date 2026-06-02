
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a field in a data source.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumn?view=office-pia"/>
public partial interface IODSOColumn: InteropObject
{
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumn.index?view=office-pia"/>
  public int Index { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumn.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Value` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumn.value?view=office-pia"/>
  public string Value { get; }
}

