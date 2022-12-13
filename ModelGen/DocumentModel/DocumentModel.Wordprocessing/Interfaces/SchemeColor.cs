namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SchemeColor Class.
/// </summary>
public interface SchemeColor
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.SchemeColorKind? Val { get ; set; }
  
  public Int32? Tint { get ; set; }
  
  public Int32? Shade { get ; set; }
  
  public Int32? Alpha { get ; set; }
  
  public Int32? HueModulation { get ; set; }
  
  public Int32? Saturation { get ; set; }
  
  public Int32? SaturationOffset { get ; set; }
  
  public Int32? SaturationModulation { get ; set; }
  
  public Int32? Luminance { get ; set; }
  
  public Int32? LuminanceOffset { get ; set; }
  
  public Int32? LuminanceModulation { get ; set; }
  
}
