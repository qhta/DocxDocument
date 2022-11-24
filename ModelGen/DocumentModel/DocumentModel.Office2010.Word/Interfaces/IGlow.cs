namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the Glow Class.
/// </summary>
public interface IGlow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// rad, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? GlowRadius { get ; set; }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public ISchemeColor? SchemeColor { get ; set; }
  
}
