namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the RgbColorModelHex Class.
/// </summary>
public interface IRgbColorModelHex // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? Val { get ; set; }
  
  public System.Int32? Tint { get ; set; }
  
  public System.Int32? Shade { get ; set; }
  
  public System.Int32? Alpha { get ; set; }
  
  public System.Int32? HueModulation { get ; set; }
  
  public System.Int32? Saturation { get ; set; }
  
  public System.Int32? SaturationOffset { get ; set; }
  
  public System.Int32? SaturationModulation { get ; set; }
  
  public System.Int32? Luminance { get ; set; }
  
  public System.Int32? LuminanceOffset { get ; set; }
  
  public System.Int32? LuminanceModulation { get ; set; }
  
}
