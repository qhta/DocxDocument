namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the GradientStop Class.
/// </summary>
public interface IGradientStop // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// pos, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? StopPosition { get ; set; }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public ISchemeColor? SchemeColor { get ; set; }
  
}
