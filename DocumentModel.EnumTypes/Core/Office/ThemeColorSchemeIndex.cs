namespace DocumentModel.Drawings;

/// <summary>
/// Indicates the color scheme for an Office theme.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msothemecolorschemeindex?view=office-pia` for Office interop details.
/// </remarks>
public enum ThemeColorSchemeIndex
{
  /// <summary>
  /// Specifies color scheme Dark 1.
  /// </summary>
  Dark1 = 1,
  /// <summary>
  /// Specifies color scheme Light 1.
  /// </summary>
  Light1,
  /// <summary>
  /// Specifies color scheme Dark 2.
  /// </summary>
  Dark2,
  /// <summary>
  /// Specifies color scheme Light 2.
  /// </summary>
  Light2,
  /// <summary>
  /// Specifies color scheme Accent 1.
  /// </summary>
  Accent1,
  /// <summary>
  /// Specifies color scheme Accent 2.
  /// </summary>
  Accent2,
  /// <summary>
  /// Specifies color scheme Accent 3.
  /// </summary>
  Accent3,
  /// <summary>
  /// Specifies color scheme Accent 4.
  /// </summary>
  Accent4,
  /// <summary>
  /// Specifies color scheme Accent 5.
  /// </summary>
  Accent5,
  /// <summary>
  /// Specifies color scheme Accent 6.
  /// </summary>
  Accent6,
  /// <summary>
  /// Specifies a color scheme for a hyperlink.
  /// </summary>
  Hyperlink,
  /// <summary>
  /// Specifies a color scheme for a clicked hyperlink.
  /// </summary>
  FollowedHyperlink
}
