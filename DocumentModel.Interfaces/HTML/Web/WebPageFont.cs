
namespace DocumentModel.Application;

/// <summary>
/// Represents the `WebPageFont` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont?view=office-pia"/>
public partial interface IWebPageFont: IModelObject
{
  /// <summary>
  /// Gets or sets the `ProportionalFont` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont.proportionalfont?view=office-pia"/>
  public string ProportionalFont { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `ProportionalFontSize` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont.proportionalfontsize?view=office-pia"/>
  public float ProportionalFontSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `FixedWidthFont` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont.fixedwidthfont?view=office-pia"/>
  public string FixedWidthFont { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `FixedWidthFontSize` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webpagefont.fixedwidthfontsize?view=office-pia"/>
  public float FixedWidthFontSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

