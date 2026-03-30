
namespace DocumentModel.Themes;

/// <summary>
/// Represents a Microsoft Office theme.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officetheme?view=office-pia"/>
public partial interface ITheme: IModelObject
{
  /// <summary>
  /// Gets the `ThemeColorScheme` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officetheme.themecolorscheme?view=office-pia"/>
  public IThemeColorScheme ThemeColorScheme { get; }
  /// <summary>
  /// Gets the `ThemeFontScheme` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officetheme.themefontscheme?view=office-pia"/>
  public IThemeFontScheme ThemeFontScheme { get; }
  /// <summary>
  /// Gets the `ThemeEffectScheme` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officetheme.themeeffectscheme?view=office-pia"/>
  public IThemeEffectScheme ThemeEffectScheme { get; }
}

