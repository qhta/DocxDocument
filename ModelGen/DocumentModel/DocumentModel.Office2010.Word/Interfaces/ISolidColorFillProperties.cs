namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the SolidColorFillProperties Class.
/// </summary>
public interface ISolidColorFillProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public DocumentModel.IHexBinaryValue? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Office2010.Word.SchemeColorKind? SchemeColor { get ; set; }
  
}
