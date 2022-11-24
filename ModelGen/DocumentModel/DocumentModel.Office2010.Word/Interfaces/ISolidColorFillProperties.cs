namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the SolidColorFillProperties Class.
/// </summary>
public interface ISolidColorFillProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public ISchemeColor? SchemeColor { get ; set; }
  
}
