namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LinearShadeProperties Class.
/// </summary>
public class LinearShadePropertiesImpl: ModelElementImpl, LinearShadeProperties
{
  public DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LinearShadePropertiesImpl(): base() {}
  
  public LinearShadePropertiesImpl(DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ang, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Angle
  {
    get => (Int32?)OpenXmlElement?.Angle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Angle = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// scaled, this property is only available in Office 2010 and later.
  /// </summary>
  public OnOffKind? Scaled
  {
    get => (OnOffKind?)OpenXmlElement?.Scaled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Scaled = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value;
    }
  }
  
}
