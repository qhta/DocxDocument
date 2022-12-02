namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SchemeColor Class.
/// </summary>
public interface ISchemeColor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.SchemeColorKind? Val { get ; set; }
  
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
