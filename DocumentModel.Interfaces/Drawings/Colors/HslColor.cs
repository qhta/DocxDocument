namespace DocumentModel.Drawings;

/// <summary>
/// Represents a color using the Hue, Saturation, and Luminance (HSL) color model, with additional color adjustment properties.
/// </summary>
public interface HslColor
{
  /// <summary>
  /// Gets or sets the base hue value.
  /// </summary>
  public Int32? HueValue { get; set; }

  /// <summary>
  /// Gets or sets the base saturation value.
  /// </summary>
  public Int32? SatValue { get; set; }

  /// <summary>
  /// Gets or sets the base luminance value.
  /// </summary>
  public Int32? LumValue { get; set; }

  /// <summary>
  /// Gets or sets the tint adjustment.
  /// </summary>
  public Int32? Tint { get; set; }

  /// <summary>
  /// Gets or sets the shade adjustment.
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
  /// Gets or sets the alpha (transparency) value.
  /// </summary>
  public Int32? Alpha { get; set; }

  /// <summary>
  /// Gets or sets the alpha offset adjustment.
  /// </summary>
  public Int32? AlphaOffset { get; set; }

  /// <summary>
  /// Gets or sets the alpha modulation adjustment.
  /// </summary>
  public Int32? AlphaModulation { get; set; }

  /// <summary>
  /// Gets or sets the hue adjustment.
  /// </summary>
  public Int32? Hue { get; set; }

  /// <summary>
  /// Gets or sets the hue offset adjustment.
  /// </summary>
  public Int32? HueOffset { get; set; }

  /// <summary>
  /// Gets or sets the hue modulation adjustment.
  /// </summary>
  public Int32? HueModulation { get; set; }

  /// <summary>
  /// Gets or sets the saturation adjustment.
  /// </summary>
  public Int32? Saturation { get; set; }

  /// <summary>
  /// Gets or sets the saturation offset adjustment.
  /// </summary>
  public Int32? SaturationOffset { get; set; }

  /// <summary>
  /// Gets or sets the saturation modulation adjustment.
  /// </summary>
  public Int32? SaturationModulation { get; set; }

  /// <summary>
  /// Gets or sets the luminance adjustment.
  /// </summary>
  public Int32? Luminance { get; set; }

  /// <summary>
  /// Gets or sets the luminance offset adjustment.
  /// </summary>
  public Int32? LuminanceOffset { get; set; }

  /// <summary>
  /// Gets or sets the luminance modulation adjustment.
  /// </summary>
  public Int32? LuminanceModulation { get; set; }

  /// <summary>
  /// Gets or sets the red channel adjustment.
  /// </summary>
  public Int32? Red { get; set; }

  /// <summary>
  /// Gets or sets the red channel offset adjustment.
  /// </summary>
  public Int32? RedOffset { get; set; }

  /// <summary>
  /// Gets or sets the red channel modulation adjustment.
  /// </summary>
  public Int32? RedModulation { get; set; }

  /// <summary>
  /// Gets or sets the green channel adjustment.
  /// </summary>
  public Int32? Green { get; set; }

  /// <summary>
  /// Gets or sets the green channel offset adjustment.
  /// </summary>
  public Int32? GreenOffset { get; set; }

  /// <summary>
  /// Gets or sets the green channel modulation adjustment.
  /// </summary>
  public Int32? GreenModulation { get; set; }

  /// <summary>
  /// Gets or sets the blue channel adjustment.
  /// </summary>
  public Int32? Blue { get; set; }

  /// <summary>
  /// Gets or sets the blue channel offset adjustment.
  /// </summary>
  public Int32? BlueOffset { get; set; }

  /// <summary>
  /// Gets or sets the blue channel modulation adjustment.
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

  /// <summary>
  /// Gets or sets the extension list for additional color properties.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}