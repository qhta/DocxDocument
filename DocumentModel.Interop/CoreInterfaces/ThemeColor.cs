using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThemeColor` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolor?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ThemeColor: InteropObject
{
  /// <summary>
  /// Gets or sets the `RGB` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolor.rgb?view=office-pia
  /// </remarks>
  public int RGB { get; set; }
  /// <summary>
  /// Gets the `ThemeColorSchemeIndex` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolor.themecolorschemeindex?view=office-pia
  /// </remarks>
  public MsoThemeColorSchemeIndex ThemeColorSchemeIndex { get; }
}
