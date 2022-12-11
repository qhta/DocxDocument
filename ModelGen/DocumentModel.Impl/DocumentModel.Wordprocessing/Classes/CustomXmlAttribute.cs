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
    get => (String?)OpenXmlElement?.Uri?.Value;
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
    get => (String?)OpenXmlElement?.Name?.Value;
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
    get => (String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
}
