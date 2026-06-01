using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThemeColor` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolor?view=office-pia"/>
public partial class ThemeColor: InteropObject
{
  /// <summary>
  /// Gets or sets the `RGB` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolor.rgb?view=office-pia"/>
  public int RGB { get; set; }
  /// <summary>
  /// Gets the `ThemeColorSchemeIndex` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolor.themecolorschemeindex?view=office-pia"/>
  public ThemeColorSchemeIndex ThemeColorSchemeIndex { get; }
}

