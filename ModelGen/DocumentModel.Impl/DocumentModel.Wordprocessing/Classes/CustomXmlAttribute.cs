namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XML Attribute.
/// </summary>
public class CustomXmlAttributeImpl: ModelElementImpl, CustomXmlAttribute
{
  public DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// uri
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// val
  /// </summary>
  public String? Val
  {
    get;
    set;
  }
  
}
