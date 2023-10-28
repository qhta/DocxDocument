namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a gradient stop. A gradient stop consists of a position where the stop appears in the color band.
/// </summary>
public partial class GradientStop
{
  
  /// <summary>
  ///   Specifies where this gradient stop should appear in the color band. This position is specified in the range, which corresponds to the beginning and the end of the color band respectively.
  /// </summary>
  public Int32? Position { get; set; }
  
  
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
