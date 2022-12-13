namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Saturation Class.
/// </summary>
public class SaturationImpl: ModelElementImpl, Saturation
{
  public DocumentFormat.OpenXml.Office2010.Drawing.Saturation? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.Saturation?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SaturationImpl(): base() {}
  
  public SaturationImpl(DocumentFormat.OpenXml.Office2010.Drawing.Saturation openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// sat, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SaturationAmount
  {
    get => (System.Int32?)OpenXmlElement?.SaturationAmount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SaturationAmount = (System.Int32?)value;
    }
  }
  
}
