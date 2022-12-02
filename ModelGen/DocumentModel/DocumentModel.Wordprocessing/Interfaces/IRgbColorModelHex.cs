namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RgbColorModelHex Class.
/// </summary>
public interface IRgbColorModelHex // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? Val { get ; set; }
  
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
