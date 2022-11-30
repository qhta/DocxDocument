namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the SolidColorFillProperties Class.
/// </summary>
public interface ISolidColorFillProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
