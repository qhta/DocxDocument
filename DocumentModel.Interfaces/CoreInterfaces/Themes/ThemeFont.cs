using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `ThemeFont` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefont?view=office-pia"/>
public partial interface ThemeFont: InteropObject
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefont.name?view=office-pia"/>
  public string Name { get; set; }
}

