namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BrightnessContrast Class.
/// </summary>
public interface IBrightnessContrast // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// bright, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Bright { get ; set; }
  
  /// <summary>
  /// contrast, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Contrast { get ; set; }
  
}
