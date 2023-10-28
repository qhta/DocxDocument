namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a glow effect, in which a color blurred outline is added outside the edges of the object.
/// </summary>
public partial class Glow
{
  
  /// <summary>
  ///   Specifies the radius of the glow.
  /// </summary>
  public Int64? Radius { get; set; }
  
  
  /// <summary>
  ///   RGB Color Model - Percentage Variant.
  /// </summary>
  public DMD.RgbColorModelPercentage? RgbColorModelPercentage { get; set; }
  
  
  /// <summary>
  ///   RGB Color Model - Hex Variant.
  /// </summary>
  public DMD.RgbColorModelHex? RgbColorModelHex { get; set; }
  
  
  /// <summary>
  ///   Hue, Saturation, Luminance Color Model.
  /// </summary>
  public DMD.HslColor? HslColor { get; set; }
  
  
  /// <summary>
  ///   System Color.
  /// </summary>
  public DMD.SystemColor? SystemColor { get; set; }
  
  
  /// <summary>
  ///   Scheme Color.
  /// </summary>
  public DMD.SchemeColorKind? SchemeColor { get; set; }
  
  
  /// <summary>
  ///   Preset Color.
  /// </summary>
  public DMD.PresetColorKind? PresetColor { get; set; }
  
}
