namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BrightnessContrast Class.
/// </summary>
public partial class BrightnessContrastImpl: ModelElementImpl, BrightnessContrast
{
  public DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BrightnessContrastImpl(): base() {}
  
  public BrightnessContrastImpl(DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// bright, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Bright
  {
    get => (System.Int32?)OpenXmlElement?.Bright?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Bright = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// contrast, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Contrast
  {
    get => (System.Int32?)OpenXmlElement?.Contrast?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Contrast = (System.Int32?)value;
    }
  }
  
}
