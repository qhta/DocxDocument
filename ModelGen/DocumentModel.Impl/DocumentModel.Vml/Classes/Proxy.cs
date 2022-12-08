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
    get;
    set;
  }
  
  /// <summary>
  /// End Point Connection Flag
  /// </summary>
  public Boolean? End
  {
    get;
    set;
  }
  
  /// <summary>
  /// Proxy Shape Reference
  /// </summary>
  public String? ShapeReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Connection Location
  /// </summary>
  public Int32? ConnectionLocation
  {
    get;
    set;
  }
  
}
