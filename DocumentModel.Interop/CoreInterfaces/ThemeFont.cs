using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThemeFont` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefont?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ThemeFont: InteropObject
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefont.name?view=office-pia
  /// </remarks>
  public string Name { get; set; }
}
