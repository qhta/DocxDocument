using System.Reflection;

namespace DocumentModel.Themes;

/// <summary>
/// Represents the `ThemeColor` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolor?view=office-pia"/>
public partial interface ThemeColor: IModelObject
{
  /// <summary>
  /// Gets or sets the `RGB` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolor.rgb?view=office-pia"/>
  public int RGB { get; set; }
  /// <summary>
  /// Gets the `ThemeColorSchemeIndex` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolor.themecolorschemeindex?view=office-pia"/>
  public ThemeColors ThemeColorSchemeIndex { get; }
}

