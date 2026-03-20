using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThemeColorScheme` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolorscheme?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ThemeColorScheme
{
  /// <summary>
  /// Invokes `Colors`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolorscheme.colors?view=office-pia
  /// </remarks>
  public ThemeColor Colors(MsoThemeColorSchemeIndex Index);
  /// <summary>
  /// Invokes `Load`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolorscheme.load?view=office-pia
  /// </remarks>
  public void Load(string FileName);
  /// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolorscheme.save?view=office-pia
  /// </remarks>
  public void Save(string FileName);
  /// <summary>
  /// Invokes `GetCustomColor`.
  /// </summary>
  /// <param name="Name">The `Name` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolorscheme.getcustomcolor?view=office-pia
  /// </remarks>
  public int GetCustomColor(string Name);
}
