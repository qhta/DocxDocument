namespace DocumentModel.Wordprocessing;

/// <summary>
///   Color class.
/// </summary>
public class Color: ModelElement
{
  /// <summary>
  /// Default contructor.
  /// </summary>
  public Color(){ }

  /// <summary>
  /// Initializes color as RGB value.
  /// </summary>
  /// <param name="rgb"></param>
  public Color(int rgb)
  { 
    RGB = rgb;
  }

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
  public Percent? ThemeTint { get; set; }

  /// <summary>
  ///   Run Content Theme Color Shade
  /// </summary>
  public Percent? ThemeShade { get; set; }

  /// <summary>
  /// Determines all properties are null.
  /// </summary>
  public bool IsEmpty()
   => RGB == null && ThemeColor == null && ThemeTint is null && ThemeShade is null;
}