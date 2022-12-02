namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ColorType Class.
/// </summary>
public interface IColorType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public DocumentModel.Wordprocessing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Wordprocessing.ISchemeColor? SchemeColor { get ; set; }
  
}
