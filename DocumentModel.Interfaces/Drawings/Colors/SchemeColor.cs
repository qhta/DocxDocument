namespace DocumentModel.Drawings;

/// <summary>
///   Represents a scheme color with various adjustment and transformation options for color manipulation.
/// </summary>
public interface SchemeColor
{
  /// <summary>
  ///   Scheme color value.
  /// </summary>
  public SchemeColorKind? Value { get; set; }

  /// <summary>
  ///   Tint adjustment value.
  /// </summary>
  public Int32? Tint { get; set; }

  /// <summary>
  ///   Shade adjustment value.
  /// </summary>
  public Int32? Shade { get; set; }

  /// <summary>
  ///   Indicates whether the complement transformation is applied.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Complement { get; set; }

  /// <summary>
  ///   Indicates whether the inverse transformation is applied.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Inverse { get; set; }

  /// <summary>
  ///   Indicates whether the gray transformation is applied.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Gray { get; set; }

  /// <summary>
  ///   Alpha value for transparency.
  /// </summary>
  public Int32? Alpha { get; set; }

  /// <summary>
  ///   Alpha offset adjustment.
  /// </summary>
  public Int32? AlphaOffset { get; set; }

  /// <summary>
  ///   Alpha modulation adjustment.
  /// </summary>
  public Int32? AlphaModulation { get; set; }

  /// <summary>
  ///   Hue value.
  /// </summary>
  public Int32? Hue { get; set; }

  /// <summary>
  ///   Hue offset adjustment.
  /// </summary>
  public Int32? HueOffset { get; set; }

  /// <summary>
  ///   Hue modulation adjustment.
  /// </summary>
  public Int32? HueModulation { get; set; }

  /// <summary>
  ///   Saturation value.
  /// </summary>
  public Int32? Saturation { get; set; }

  /// <summary>
  ///   Saturation offset adjustment.
  /// </summary>
  public Int32? SaturationOffset { get; set; }

  /// <summary>
  ///   Saturation modulation adjustment.
  /// </summary>
  public Int32? SaturationModulation { get; set; }

  /// <summary>
  ///   Luminance value.
  /// </summary>
  public Int32? Luminance { get; set; }

  /// <summary>
  ///   Luminance offset adjustment.
  /// </summary>
  public Int32? LuminanceOffset { get; set; }

  /// <summary>
  ///   Luminance modulation adjustment.
  /// </summary>
  public Int32? LuminanceModulation { get; set; }

  /// <summary>
  ///   Red channel value.
  /// </summary>
  public Int32? Red { get; set; }

  /// <summary>
  ///   Red channel offset adjustment.
  /// </summary>
  public Int32? RedOffset { get; set; }

  /// <summary>
  ///   Red channel modulation adjustment.
  /// </summary>
  public Int32? RedModulation { get; set; }

  /// <summary>
  ///   Green channel value.
  /// </summary>
  public Int32? Green { get; set; }

  /// <summary>
  ///   Green channel offset adjustment.
  /// </summary>
  public Int32? GreenOffset { get; set; }

  /// <summary>
  ///   Green channel modulation adjustment.
  /// </summary>
  public Int32? GreenModulation { get; set; }

  /// <summary>
  ///   Blue channel value.
  /// </summary>
  public Int32? Blue { get; set; }

  /// <summary>
  ///   Blue channel offset adjustment.
  /// </summary>
  public Int32? BlueOffset { get; set; }

  /// <summary>
  ///   Blue channel modulation adjustment.
  /// </summary>
  public Int32? BlueModulation { get; set; }

  /// <summary>
  ///   Indicates whether gamma correction is applied.
  /// </summary>
  [DefaultValue(false)]
  public Boolean Gamma { get; set; }

  /// <summary>
  ///   Indicates whether inverse gamma correction is applied.
  /// </summary>
  [DefaultValue(false)]
  public Boolean InverseGamma { get; set; }
}