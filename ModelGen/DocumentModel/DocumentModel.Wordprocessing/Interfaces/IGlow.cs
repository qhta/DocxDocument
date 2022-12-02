namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Glow Class.
/// </summary>
public interface IGlow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// rad, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int64? GlowRadius { get ; set; }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public DocumentModel.Wordprocessing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Wordprocessing.ISchemeColor? SchemeColor { get ; set; }
  
}
