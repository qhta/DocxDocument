
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThemeEffectScheme` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themeeffectscheme?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ThemeEffectScheme
{
  /// <summary>
  /// Invokes `Load`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themeeffectscheme.load?view=office-pia
  /// </remarks>
  public void Load(string FileName);
}
