namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SchemeColor Class.
/// </summary>
public interface SchemeColor
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public SchemeColorKind? Val { get ; set; }
  
  public Collection<Int32>? Tints { get ; set; }
  
  public Collection<Int32>? Shades { get ; set; }
  
  public Collection<Int32>? Alphas { get ; set; }
  
  public Collection<Int32>? HueModulations { get ; set; }
  
  public Collection<Int32>? Saturations { get ; set; }
  
  public Collection<Int32>? SaturationOffsets { get ; set; }
  
  public Collection<Int32>? SaturationModulations { get ; set; }
  
  public Collection<Int32>? Luminances { get ; set; }
  
  public Collection<Int32>? LuminanceOffsets { get ; set; }
  
  public Collection<Int32>? LuminanceModulations { get ; set; }
  
}
