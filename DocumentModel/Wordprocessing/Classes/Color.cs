namespace DocumentModel.Wordprocessing;

/// <summary>
///   Color class.
/// </summary>
public class Color: ModelElement
{
  /// <summary>
  ///   Run Content Color
  /// </summary>
  public RGB? RGB { get; set; }

  /// <summary>
  ///   Run Content Theme Color
  /// </summary>
  public ThemeColorKind? ThemeColor { get; set; }

  /// <summary>
  ///   Run Content Theme Color Tint
  /// </summary>
  public BytePercent? ThemeTint { get; set; }

  /// <summary>
  ///   Run Content Theme Color Shade
  /// </summary>
  public BytePercent? ThemeShade { get; set; }

  /// <summary>
  /// Determines all properties are null.
  /// </summary>
  public bool IsEmpty()
   => RGB == null && ThemeColor == null && ThemeTint is null && ThemeShade is null;
}