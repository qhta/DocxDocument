using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Shading Class.
/// </summary>
public class Shading: ModelElement
{
  /// <summary>
  ///   Shading Pattern
  /// </summary>
  public ShadingPatternKind? Pattern { get; set; }

  public Color? ForegroundColor {get; set; }

  public Color? BackgroundColor {get; set; }

  ///// <summary>
  /////   Shading Pattern Color
  ///// </summary>
  //public RGB? Color { get; set; }

  ///// <summary>
  /////   Shading Pattern Theme Color
  ///// </summary>
  //public ThemeColorKind? ThemeColor { get; set; }

  ///// <summary>
  /////   Shading Pattern Theme Color Tint
  ///// </summary>
  //public BytePercent? ThemeTint { get; set; }

  ///// <summary>
  /////   Shading Pattern Theme Color Shade
  ///// </summary>
  //public BytePercent? ThemeShade { get; set; }

  ///// <summary>
  /////   Shading Background Color
  ///// </summary>
  //public RGB? Fill { get; set; }

  ///// <summary>
  /////   Shading Background Theme Color
  ///// </summary>
  //public ThemeColorKind? ThemeFill { get; set; }

  ///// <summary>
  /////   Shading Background Theme Color Tint
  ///// </summary>
  //public BytePercent? ThemeFillTint { get; set; }

  ///// <summary>
  /////   Shading Background Theme Color Shade
  ///// </summary>
  //public BytePercent? ThemeFillShade { get; set; }
}