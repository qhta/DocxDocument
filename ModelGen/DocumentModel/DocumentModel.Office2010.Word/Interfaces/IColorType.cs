namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the ColorType Class.
/// </summary>
public interface IColorType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public DocumentModel.Office2010.Word.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Office2010.Word.ISchemeColor? SchemeColor { get ; set; }
  
}
