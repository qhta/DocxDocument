namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BrightnessContrast Class.
/// </summary>
public class BrightnessContrastImpl: ModelElementImpl, BrightnessContrast
{
  public DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// bright, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Bright
  {
    get;
    set;
  }
  
  /// <summary>
  /// contrast, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Contrast
  {
    get;
    set;
  }
  
}
