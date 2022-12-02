namespace DocumentModel.Wordprocessing;

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
  public DocumentModel.Wordprocessing.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Wordprocessing.ISchemeColor? SchemeColor { get ; set; }
  
}
