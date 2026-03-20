
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `OfficeTheme` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officetheme?view=office-pia` for Office interop details.
/// </remarks>
public partial interface OfficeTheme: InteropObject
{
  /// <summary>
  /// Gets the `ThemeColorScheme` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officetheme.themecolorscheme?view=office-pia
  /// </remarks>
  public ThemeColorScheme ThemeColorScheme { get; }
  /// <summary>
  /// Gets the `ThemeFontScheme` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officetheme.themefontscheme?view=office-pia
  /// </remarks>
  public ThemeFontScheme ThemeFontScheme { get; }
  /// <summary>
  /// Gets the `ThemeEffectScheme` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officetheme.themeeffectscheme?view=office-pia
  /// </remarks>
  public ThemeEffectScheme ThemeEffectScheme { get; }
}
