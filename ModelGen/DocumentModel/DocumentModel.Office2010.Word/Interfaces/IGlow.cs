namespace DocumentModel.Office2010.Word;

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
  public DocumentModel.IHexBinaryValue? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Office2010.Word.SchemeColorKind? SchemeColor { get ; set; }
  
}
