namespace DocumentModel.Properties;

/// <summary>
/// Custom File Property.
/// </summary>
public partial class CustomDocumentPropertyImpl: ModelElementImpl, CustomDocumentProperty
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CustomDocumentPropertyImpl(): base() {}
  
  public CustomDocumentPropertyImpl(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Format ID
  /// </summary>
  public String? FormatId
  {
    get => (System.String?)OpenXmlElement?.FormatId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FormatId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Property ID
  /// </summary>
  public Int32? PropertyId
  {
    get => (System.Int32?)OpenXmlElement?.PropertyId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PropertyId = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Custom File Property Name
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
  /// Bookmark Link Target
  /// </summary>
  public String? LinkTarget
  {
    get => (System.String?)OpenXmlElement?.LinkTarget?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LinkTarget = (System.String?)value;
    }
  }

  
}
