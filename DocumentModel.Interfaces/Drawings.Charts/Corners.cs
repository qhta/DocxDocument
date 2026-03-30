
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents chart corners.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners?view=office-pia"/>
public partial interface Corners: IModelObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners.name?view=office-pia"/>
  public string Name { get; }
}

