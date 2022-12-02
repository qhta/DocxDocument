namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StyleColor Class.
/// </summary>
public interface IStyleColor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// val, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Val { get ; set; }
  
  public System.Int32? Tint { get ; set; }
  
  public System.Int32? Shade { get ; set; }
  
  public System.Boolean? Complement { get ; set; }
  
  public System.Boolean? Inverse { get ; set; }
  
  public System.Boolean? Gray { get ; set; }
  
  public System.Int32? Alpha { get ; set; }
  
  public System.Int32? AlphaOffset { get ; set; }
  
  public System.Int32? AlphaModulation { get ; set; }
  
  public System.Int32? Hue { get ; set; }
  
  public System.Int32? HueOffset { get ; set; }
  
  public System.Int32? HueModulation { get ; set; }
  
  public System.Int32? Saturation { get ; set; }
  
  public System.Int32? SaturationOffset { get ; set; }
  
  public System.Int32? SaturationModulation { get ; set; }
  
  public System.Int32? Luminance { get ; set; }
  
  public System.Int32? LuminanceOffset { get ; set; }
  
  public System.Int32? LuminanceModulation { get ; set; }
  
  public System.Int32? Red { get ; set; }
  
  public System.Int32? RedOffset { get ; set; }
  
  public System.Int32? RedModulation { get ; set; }
  
  public System.Int32? Green { get ; set; }
  
  public System.Int32? GreenOffset { get ; set; }
  
  public System.Int32? GreenModulation { get ; set; }
  
  public System.Int32? Blue { get ; set; }
  
  public System.Int32? BlueOffset { get ; set; }
  
  public System.Int32? BlueModulation { get ; set; }
  
  public System.Boolean? Gamma { get ; set; }
  
  public System.Boolean? InverseGamma { get ; set; }
  
}
