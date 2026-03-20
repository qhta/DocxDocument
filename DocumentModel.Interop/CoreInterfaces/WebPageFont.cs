
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WebPageFont` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont?view=office-pia` for Office interop details.
/// </remarks>
public partial interface WebPageFont: InteropObject
{
  /// <summary>
  /// Gets or sets the `ProportionalFont` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont.proportionalfont?view=office-pia
  /// </remarks>
  public string ProportionalFont { get; set; }
  /// <summary>
  /// Gets or sets the `ProportionalFontSize` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont.proportionalfontsize?view=office-pia
  /// </remarks>
  public float ProportionalFontSize { get; set; }
  /// <summary>
  /// Gets or sets the `FixedWidthFont` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont.fixedwidthfont?view=office-pia
  /// </remarks>
  public string FixedWidthFont { get; set; }
  /// <summary>
  /// Gets or sets the `FixedWidthFontSize` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont.fixedwidthfontsize?view=office-pia
  /// </remarks>
  public float FixedWidthFontSize { get; set; }
}
