namespace DocumentModel.Themes;

/// <summary>
/// Represents the `ThemeColor` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolor?view=office-pia"/>
public partial interface IThemeColor : IModelObject
{
  /// <summary>
  /// Gets or sets the `RGB` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolor.rgb?view=office-pia"/>
  public uint? RGB { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `ThemeColorSchemeIndex` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolor.themecolorschemeindex?view=office-pia"/>
  public DMD.SchemeColors ThemeColorSchemeIndex { get; }
}

