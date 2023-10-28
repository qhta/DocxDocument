namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a custom color.  The custom colors are used within a custom color list to define custom colors that are extra colors that can be appended to a theme.  This is useful within corporate scenarios where there is a set corporate color palette from which to work.
/// </summary>
public partial class CustomColor
{
  
  /// <summary>
  ///   The name of the color shown in the color picker.
  /// </summary>
  public String? Name { get; set; }
  
  
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
