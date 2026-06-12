namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
/// Describes a variation of a color style, allowing adjustments to tint, shade, alpha, hue, saturation, luminance, and color channels for chart elements.
/// </summary>
[XmlRoot("ColorStyleVariation", Namespace = "DocumentModel.Drawings.ChartsStyle")]
public partial class ColorStyleVariation : CollectionItem
{
  /// <summary>
  /// Tint adjustment value for the color variation.
  /// </summary>
  public Int32? Tint { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Shade adjustment value for the color variation.
  /// </summary>
  public Int32? Shade { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Indicates if the complement of the color is used.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Complement { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Indicates if the inverse of the color is used.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Inverse { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Indicates if the color is converted to grayscale.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Gray { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Alpha (opacity) value for the color variation.
  /// </summary>
  public Int32? Alpha { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Offset applied to the alpha value.
  /// </summary>
  public Int32? AlphaOffset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Modulation factor for the alpha value.
  /// </summary>
  public Int32? AlphaModulation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Hue value for the color variation.
  /// </summary>
  public Int32? Hue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Offset applied to the hue value.
  /// </summary>
  public Int32? HueOffset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Modulation factor for the hue value.
  /// </summary>
  public Int32? HueModulation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Saturation value for the color variation.
  /// </summary>
  public Int32? Saturation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Offset applied to the saturation value.
  /// </summary>
  public Int32? SaturationOffset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Modulation factor for the saturation value.
  /// </summary>
  public Int32? SaturationModulation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Luminance value for the color variation.
  /// </summary>
  public Int32? Luminance { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Offset applied to the luminance value.
  /// </summary>
  public Int32? LuminanceOffset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Modulation factor for the luminance value.
  /// </summary>
  public Int32? LuminanceModulation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Red channel value for the color variation.
  /// </summary>
  public Int32? Red { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Offset applied to the red channel value.
  /// </summary>
  public Int32? RedOffset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Modulation factor for the red channel value.
  /// </summary>
  public Int32? RedModulation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Green channel value for the color variation.
  /// </summary>
  public Int32? Green { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Offset applied to the green channel value.
  /// </summary>
  public Int32? GreenOffset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Modulation factor for the green channel value.
  /// </summary>
  public Int32? GreenModulation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Blue channel value for the color variation.
  /// </summary>
  public Int32? Blue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Offset applied to the blue channel value.
  /// </summary>
  public Int32? BlueOffset { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Modulation factor for the blue channel value.
  /// </summary>
  public Int32? BlueModulation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Indicates if gamma correction is applied to the color.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Gamma { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Indicates if inverse gamma correction is applied to the color.
  /// </summary>
  [DefaultValue(false)]
  public Boolean InverseGamma { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}