namespace DocumentModel.Application;

/// <summary>
/// Represents a field in a data source.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumn?view=office-pia"/>
public partial interface IODSOColumn: IModelObject
{
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumn.index?view=office-pia"/>
  public int Index { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumn.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Value` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsocolumn.value?view=office-pia"/>
  public string Value { get; }
}

