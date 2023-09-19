namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a hue/saturation/luminance effect. The hue, saturation, and luminance can each be adjusted relative to its current value.
/// </summary>
public partial class Hsl
{
  
  /// <summary>
  ///   Specifies the number of degrees by which the hue is adjusted.
  /// </summary>
  [SchemaAttr("hue")]
  public Int32? Hue { get; set; }
  
  
  /// <summary>
  ///   Specifies the percentage by which the saturation is adjusted.
  /// </summary>
  [SchemaAttr("sat")]
  public Int32? Saturation { get; set; }
  
  
  /// <summary>
  ///   Specifies the percentage by which the luminance is adjusted.
  /// </summary>
  [SchemaAttr("lum")]
  public Int32? Luminance { get; set; }
  
}
