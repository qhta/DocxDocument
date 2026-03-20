
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThemeFontScheme` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme?view=office-pia
/// </remarks>
public partial interface ThemeFontScheme: InteropObject
{
  /// <summary>
  /// Gets the `MinorFont` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.minorfont?view=office-pia
  /// </remarks>
  public ThemeFonts MinorFont { get; }
  /// <summary>
  /// Gets the `MajorFont` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.majorfont?view=office-pia
  /// </remarks>
  public ThemeFonts MajorFont { get; }
}
