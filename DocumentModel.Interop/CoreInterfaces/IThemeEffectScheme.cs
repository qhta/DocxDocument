
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThemeEffectScheme` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themeeffectscheme?view=office-pia` for Office interop details.
/// </remarks>
public interface IThemeEffectScheme: IInteropObject
{


  #region methods

/// <summary>
  /// Invokes `Load`.
  /// </summary>
  /// <param name="fileName">The `FileName` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themeeffectscheme.load?view=office-pia"/>
  public void Load(string fileName);

  #endregion methods
}
