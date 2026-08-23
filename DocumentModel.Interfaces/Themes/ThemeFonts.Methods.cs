namespace DocumentModel.Themes;

/// <summary>
/// Represents the `ThemeFonts` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefonts?view=office-pia"/>
public partial interface IThemeFonts : IModelObject
{
  /// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefonts.item?view=office-pia"/>
  public IThemeFont Item(FontLanguageIndex Index);
}

