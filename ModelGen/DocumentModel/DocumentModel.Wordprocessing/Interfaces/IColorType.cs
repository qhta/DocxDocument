namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ColorType Class.
/// </summary>
public interface IColorType // : DocumentModel.ITypedOpenXmlCompositeElement
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
