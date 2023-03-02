namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Color Class.
/// </summary>
public record Color3
{
  /// <summary>
  ///   Run Content Color
  /// </summary>
  public String? Val { get; set; }

  /// <summary>
  ///   Run Content Theme Color
  /// </summary>
  public ThemeColorKind? ThemeColor { get; set; }

  /// <summary>
  ///   Run Content Theme Color Tint
  /// </summary>
  public String? ThemeTint { get; set; }

  /// <summary>
  ///   Run Content Theme Color Shade
  /// </summary>
  public String? ThemeShade { get; set; }
}