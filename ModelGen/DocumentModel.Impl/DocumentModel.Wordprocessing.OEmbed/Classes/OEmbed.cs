namespace DocumentModel.Wordprocessing.OEmbed;

/// <summary>
/// Defines the OEmbed Class.
/// </summary>
public partial class OEmbedImpl: ModelElementImpl, OEmbed
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public OEmbedImpl(): base() {}
  
  public OEmbedImpl(DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// oEmbedUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? OEmbedUrl
  {
    get => (System.String?)OpenXmlElement?.OEmbedUrl?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OEmbedUrl = (System.String?)value;
    }
  }
  
  /// <summary>
  /// mediaType, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? MediaType
  {
    get => (System.String?)OpenXmlElement?.MediaType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MediaType = (System.String?)value;
    }
  }
  
  /// <summary>
  /// picLocksAutoForOEmbed, this property is only available in Microsoft365 and later.
  /// </summary>
  public Boolean? PicLocksAutoForOEmbed
  {
    get => (System.Boolean?)OpenXmlElement?.PicLocksAutoForOEmbed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PicLocksAutoForOEmbed = (System.Boolean?)value;
    }
  }
  
}
