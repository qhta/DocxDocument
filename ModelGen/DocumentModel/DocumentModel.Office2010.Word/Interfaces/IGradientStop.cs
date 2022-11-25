namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the GradientStop Class.
/// </summary>
public interface IGradientStop // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// pos, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? StopPosition { get ; set; }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public DocumentModel.IHexBinaryValue? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Office2010.Word.SchemeColorKind? SchemeColor { get ; set; }
  
}
