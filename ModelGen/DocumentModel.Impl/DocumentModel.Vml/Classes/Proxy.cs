namespace DocumentModel.Vml;

/// <summary>
/// Shape Reference.
/// </summary>
public class ProxyImpl: ModelElementImpl, Proxy
{
  public DocumentFormat.OpenXml.Vml.Office.Proxy? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Proxy?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Start Point Connection Flag
  /// </summary>
  public Boolean? Start
  {
    get => (Boolean?)OpenXmlElement?.Start?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Start = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// End Point Connection Flag
  /// </summary>
  public Boolean? End
  {
    get => (Boolean?)OpenXmlElement?.End?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.End = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Proxy Shape Reference
  /// </summary>
  public String? ShapeReference
  {
    get => (String?)OpenXmlElement?.ShapeReference?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShapeReference = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Connection Location
  /// </summary>
  public Int32? ConnectionLocation
  {
    get => (Int32?)OpenXmlElement?.ConnectionLocation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ConnectionLocation = (System.Int32?)value;
    }
  }
  
}
