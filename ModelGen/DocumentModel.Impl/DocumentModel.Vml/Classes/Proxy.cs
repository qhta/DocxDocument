namespace DocumentModel.Vml;

/// <summary>
/// Shape Reference.
/// </summary>
public partial class ProxyImpl: ModelElementImpl, Proxy
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Vml.Office.Proxy? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Proxy?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ProxyImpl(): base() {}
  
  public ProxyImpl(DocumentFormat.OpenXml.Vml.Office.Proxy openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Start Point Connection Flag
  /// </summary>
  public Boolean? Start
  {
    get => (System.Boolean?)OpenXmlElement?.Start?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.End?.Value;
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
    get => (System.String?)OpenXmlElement?.ShapeReference?.Value;
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
    get => (System.Int32?)OpenXmlElement?.ConnectionLocation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ConnectionLocation = (System.Int32?)value;
    }
  }
  
}
