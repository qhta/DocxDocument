
namespace DocumentModel.Drawings.SmartArt;

/// <summary>
/// Represents the `SmartArtColor` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartcolor?view=office-pia"/>
public partial interface ISmartArtColor: IModelObject
{
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartcolor.id?view=office-pia"/>
  public string Id { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartcolor.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartcolor.description?view=office-pia"/>
  public string Description { get; }
  /// <summary>
  /// Gets the `Category` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartcolor.category?view=office-pia"/>
  public string Category { get; }
}

