namespace DocumentModel.Drawings;

/// <summary>
/// Represents a color using the Hue, Saturation, and Luminance (HSL) color model, with additional color adjustment properties.
/// </summary>
public interface HslColor: ExtendableElement
{
  /// <summary>
  /// Base hue value.
  /// </summary>
  public Int32? HueValue { get; set; }

  /// <summary>
  /// Base saturation value.
  /// </summary>
  public Int32? SatValue { get; set; }

  /// <summary>
  /// Base luminance value.
  /// </summary>
  public Int32? LumValue { get; set; }

  /// <summary>
  /// Tint adjustment.
  /// </summary>
  public Int32? Tint { get; set; }

  /// <summary>
  /// Shade adjustment.
  /// </summary>
  public Int32? Shade { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the color is complemented.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Complement { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the color is inverted.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Inverse { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the color is converted to grayscale.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Gray { get; set; }

  /// <summary>
  /// Alpha (transparency) value.
  /// </summary>
  public Int32? Alpha { get; set; }

  /// <summary>
  /// Alpha offset adjustment.
  /// </summary>
  public Int32? AlphaOffset { get; set; }

  /// <summary>
  /// Alpha modulation adjustment.
  /// </summary>
  public Int32? AlphaModulation { get; set; }

  /// <summary>
  /// Hue adjustment.
  /// </summary>
  public Int32? Hue { get; set; }

  /// <summary>
  /// Hue offset adjustment.
  /// </summary>
  public Int32? HueOffset { get; set; }

  /// <summary>
  /// Hue modulation adjustment.
  /// </summary>
  public Int32? HueModulation { get; set; }

  /// <summary>
  /// Saturation adjustment.
  /// </summary>
  public Int32? Saturation { get; set; }

  /// <summary>
  /// Saturation offset adjustment.
  /// </summary>
  public Int32? SaturationOffset { get; set; }

  /// <summary>
  /// Saturation modulation adjustment.
  /// </summary>
  public Int32? SaturationModulation { get; set; }

  /// <summary>
  /// Luminance adjustment.
  /// </summary>
  public Int32? Luminance { get; set; }

  /// <summary>
  /// Luminance offset adjustment.
  /// </summary>
  public Int32? LuminanceOffset { get; set; }

  /// <summary>
  /// Luminance modulation adjustment.
  /// </summary>
  public Int32? LuminanceModulation { get; set; }

  /// <summary>
  /// Red channel adjustment.
  /// </summary>
  public Int32? Red { get; set; }

  /// <summary>
  /// Red channel offset adjustment.
  /// </summary>
  public Int32? RedOffset { get; set; }

  /// <summary>
  /// Red channel modulation adjustment.
  /// </summary>
  public Int32? RedModulation { get; set; }

  /// <summary>
  /// Green channel adjustment.
  /// </summary>
  public Int32? Green { get; set; }

  /// <summary>
  /// Green channel offset adjustment.
  /// </summary>
  public Int32? GreenOffset { get; set; }

  /// <summary>
  /// Green channel modulation adjustment.
  /// </summary>
  public Int32? GreenModulation { get; set; }

  /// <summary>
  /// Blue channel adjustment.
  /// </summary>
  public Int32? Blue { get; set; }

  /// <summary>
  /// Blue channel offset adjustment.
  /// </summary>
  public Int32? BlueOffset { get; set; }

  /// <summary>
  /// Blue channel modulation adjustment.
  /// </summary>
  public Int32? BlueModulation { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether gamma correction is applied.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Gamma { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether inverse gamma correction is applied.
  /// </summary>
  [DefaultValue(false)]
  public Boolean InverseGamma { get; set; }
}