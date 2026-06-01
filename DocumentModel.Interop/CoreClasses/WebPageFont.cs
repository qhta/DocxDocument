
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WebPageFont` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont?view=office-pia"/>
public partial class WebPageFont: InteropObject
{
  /// <summary>
  /// Gets or sets the `ProportionalFont` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont.proportionalfont?view=office-pia"/>
  public string ProportionalFont { get; set; }
  /// <summary>
  /// Gets or sets the `ProportionalFontSize` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont.proportionalfontsize?view=office-pia"/>
  public float ProportionalFontSize { get; set; }
  /// <summary>
  /// Gets or sets the `FixedWidthFont` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont.fixedwidthfont?view=office-pia"/>
  public string FixedWidthFont { get; set; }
  /// <summary>
  /// Gets or sets the `FixedWidthFontSize` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont.fixedwidthfontsize?view=office-pia"/>
  public float FixedWidthFontSize { get; set; }
}

