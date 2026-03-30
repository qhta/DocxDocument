using System.Collections;
using System.Reflection;

namespace DocumentModel.Themes;

/// <summary>
/// Represents the `ThemeFonts` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefonts?view=office-pia"/>
public partial interface ThemeFonts: IModelObject
{
  /// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefonts.item?view=office-pia"/>
  public ThemeFont Item(FontLanguageIndex Index);
}

