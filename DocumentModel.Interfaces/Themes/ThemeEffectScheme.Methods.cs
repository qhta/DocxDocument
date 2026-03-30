
namespace DocumentModel.Themes;

/// <summary>
/// Represents the `ThemeEffectScheme` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themeeffectscheme?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IThemeEffectScheme: IModelObject
{
  /// <summary>
  /// Invokes `Load`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themeeffectscheme.load?view=office-pia"/>
  public void Load(string FileName);
}

