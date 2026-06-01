using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThemeColorScheme` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolorscheme?view=office-pia"/>
public partial class ThemeColorScheme
{
  /// <summary>
  /// Invokes `Colors`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolorscheme.colors?view=office-pia"/>
  public ThemeColor Colors(ThemeColorSchemeIndex Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Load`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolorscheme.load?view=office-pia"/>
  public void Load(string FileName) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolorscheme.save?view=office-pia"/>
  public void Save(string FileName) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCustomColor`.
  /// </summary>
  /// <param name="Name">The `Name` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themecolorscheme.getcustomcolor?view=office-pia"/>
  public int GetCustomColor(string Name) { throw new NotImplementedException(); }
}

