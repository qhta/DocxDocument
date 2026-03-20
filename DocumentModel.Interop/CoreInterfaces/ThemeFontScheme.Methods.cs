
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThemeFontScheme` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ThemeFontScheme
{
  /// <summary>
  /// Invokes `Load`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.load?view=office-pia
  /// </remarks>
  public void Load(string FileName);
  /// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.save?view=office-pia
  /// </remarks>
  public void Save(string FileName);
}
