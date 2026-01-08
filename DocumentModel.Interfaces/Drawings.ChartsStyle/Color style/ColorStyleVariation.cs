namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Describes a variation of a color style, allowing adjustments to tint, shade, alpha, hue, saturation, luminance, and color channels for chart elements.
/// </summary>
public interface ColorStyleVariation : CollectionItem
{
  /// <summary>
  /// Tint adjustment value for the color variation.
  /// </summary>
  public Int32? Tint { get; set; }

  /// <summary>
  /// Shade adjustment value for the color variation.
  /// </summary>
  public Int32? Shade { get; set; }

  /// <summary>
  /// Indicates if the complement of the color is used.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Complement { get; set; }

  /// <summary>
  /// Indicates if the inverse of the color is used.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Inverse { get; set; }

  /// <summary>
  /// Indicates if the color is converted to grayscale.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Gray { get; set; }

  /// <summary>
  /// Alpha (opacity) value for the color variation.
  /// </summary>
  public Int32? Alpha { get; set; }

  /// <summary>
  /// Offset applied to the alpha value.
  /// </summary>
  public Int32? AlphaOffset { get; set; }

  /// <summary>
  /// Modulation factor for the alpha value.
  /// </summary>
  public Int32? AlphaModulation { get; set; }

  /// <summary>
  /// Hue value for the color variation.
  /// </summary>
  public Int32? Hue { get; set; }

  /// <summary>
  /// Offset applied to the hue value.
  /// </summary>
  public Int32? HueOffset { get; set; }

  /// <summary>
  /// Modulation factor for the hue value.
  /// </summary>
  public Int32? HueModulation { get; set; }

  /// <summary>
  /// Saturation value for the color variation.
  /// </summary>
  public Int32? Saturation { get; set; }

  /// <summary>
  /// Offset applied to the saturation value.
  /// </summary>
  public Int32? SaturationOffset { get; set; }

  /// <summary>
  /// Modulation factor for the saturation value.
  /// </summary>
  public Int32? SaturationModulation { get; set; }

  /// <summary>
  /// Luminance value for the color variation.
  /// </summary>
  public Int32? Luminance { get; set; }

  /// <summary>
  /// Offset applied to the luminance value.
  /// </summary>
  public Int32? LuminanceOffset { get; set; }

  /// <summary>
  /// Modulation factor for the luminance value.
  /// </summary>
  public Int32? LuminanceModulation { get; set; }

  /// <summary>
  /// Red channel value for the color variation.
  /// </summary>
  public Int32? Red { get; set; }

  /// <summary>
  /// Offset applied to the red channel value.
  /// </summary>
  public Int32? RedOffset { get; set; }

  /// <summary>
  /// Modulation factor for the red channel value.
  /// </summary>
  public Int32? RedModulation { get; set; }

  /// <summary>
  /// Green channel value for the color variation.
  /// </summary>
  public Int32? Green { get; set; }

  /// <summary>
  /// Offset applied to the green channel value.
  /// </summary>
  public Int32? GreenOffset { get; set; }

  /// <summary>
  /// Modulation factor for the green channel value.
  /// </summary>
  public Int32? GreenModulation { get; set; }

  /// <summary>
  /// Blue channel value for the color variation.
  /// </summary>
  public Int32? Blue { get; set; }

  /// <summary>
  /// Offset applied to the blue channel value.
  /// </summary>
  public Int32? BlueOffset { get; set; }

  /// <summary>
  /// Modulation factor for the blue channel value.
  /// </summary>
  public Int32? BlueModulation { get; set; }

  /// <summary>
  /// Indicates if gamma correction is applied to the color.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Gamma { get; set; }

  /// <summary>
  /// Indicates if inverse gamma correction is applied to the color.
  /// </summary>
  [DefaultValue(false)]
  public Boolean InverseGamma { get; set; }
}