
namespace DocumentModel.Interfaces;

/// <summary>
/// Represents the `SmartArtQuickStyle` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartquickstyle?view=office-pia"/>
public partial interface SmartArtQuickStyle: InteropObject
{
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartquickstyle.id?view=office-pia"/>
  public string Id { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartquickstyle.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartquickstyle.description?view=office-pia"/>
  public string Description { get; }
  /// <summary>
  /// Gets the `Category` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartquickstyle.category?view=office-pia"/>
  public string Category { get; }
}

