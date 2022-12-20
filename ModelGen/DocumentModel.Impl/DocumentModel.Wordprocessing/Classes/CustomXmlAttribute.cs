namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XML Attribute.
/// </summary>
public partial class CustomXmlAttributeImpl: ModelElementImpl, CustomXmlAttribute
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CustomXmlAttributeImpl(): base() {}
  
  public CustomXmlAttributeImpl(DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// uri
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// val
  /// </summary>
  public String? Val
  {
    get => (System.String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
}
