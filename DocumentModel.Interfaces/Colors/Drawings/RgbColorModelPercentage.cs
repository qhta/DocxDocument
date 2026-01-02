namespace DocumentModel.Drawings;

/// <summary>
///   RGB Color Model - Percentage Variant.
/// </summary>
public class RgbColorModelPercentage: ModelElement
{
  /// <summary>
  ///   Red
  /// </summary>
  public Int32? RedPortion { get; set; }
  /// <summary>
  ///   Green
  /// </summary>
  public Int32? GreenPortion { get; set; }
  /// <summary>
  ///   Blue
  /// </summary>
  public Int32? BluePortion { get; set; }
  public Int32? Tint { get; set; }
  public Int32? Shade { get; set; }
  [DefaultValue(false)]
  public Boolean Complement { get; set; }
  [DefaultValue(false)]
  public Boolean Inverse { get; set; }
  [DefaultValue(false)]
  public Boolean Gray { get; set; }
  public Int32? Alpha { get; set; }
  public Int32? AlphaOffset { get; set; }
  public Int32? AlphaModulation { get; set; }
  public Int32? Hue { get; set; }
  public Int32? HueOffset { get; set; }
  public Int32? HueModulation { get; set; }
  public Int32? Saturation { get; set; }
  public Int32? SaturationOffset { get; set; }
  public Int32? SaturationModulation { get; set; }
  public Int32? Luminance { get; set; }
  public Int32? LuminanceOffset { get; set; }
  public Int32? LuminanceModulation { get; set; }
  public Int32? Red { get; set; }
  public Int32? RedOffset { get; set; }
  public Int32? RedModulation { get; set; }
  public Int32? Green { get; set; }
  public Int32? GreenOffset { get; set; }
  public Int32? GreenModulation { get; set; }
  public Int32? Blue { get; set; }
  public Int32? BlueOffset { get; set; }
  public Int32? BlueModulation { get; set; }
  [DefaultValue(false)]
  public Boolean Gamma { get; set; }
  [DefaultValue(false)]
  public Boolean InverseGamma { get; set; }
}