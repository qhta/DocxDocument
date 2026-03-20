namespace DocumentModel.Interop;

/// <summary>
/// Represents the color of a one-color object or the foreground or background color of an object with a gradient or patterned fill.
/// </summary>
public partial interface ColorFormat : InteropObject
{
  /// <summary>
  /// The rgb.
  /// </summary>
  public int RGB { get; set; }

  /// <summary>
  /// The scheme color.
  /// </summary>
  public int SchemeColor { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  //public Core.MsoColorType Type { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// The tint and shade.
  /// </summary>
  public float TintAndShade { get; set; }

  /// <summary>
  /// The over print.
  /// </summary>
  //public Core.MsoTriState OverPrint { get; set; }

  /// <summary>
  /// The cyan.
  /// </summary>
  public int Cyan { get; set; }

  /// <summary>
  /// The magenta.
  /// </summary>
  public int Magenta { get; set; }

  /// <summary>
  /// The yellow.
  /// </summary>
  public int Yellow { get; set; }

  /// <summary>
  /// The black.
  /// </summary>
  public int Black { get; set; }

  /// <summary>
  /// The object theme color.
  /// </summary>
  public WdThemeColorIndex ObjectThemeColor { get; set; }

  /// <summary>
  /// The brightness.
  /// </summary>
  public float Brightness { get; set; }
}
