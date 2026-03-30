
namespace DocumentModel.Themes;

/// <summary>
/// Represents the `ThemeFontScheme` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme?view=office-pia"/>
public partial interface ThemeFontScheme: IModelObject
{
  /// <summary>
  /// Gets the `MinorFont` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.minorfont?view=office-pia"/>
  public ThemeFonts MinorFont { get; }
  /// <summary>
  /// Gets the `MajorFont` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.majorfont?view=office-pia"/>
  public ThemeFonts MajorFont { get; }
}

