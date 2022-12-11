namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the OEmbed Class.
/// </summary>
public class OEmbedImpl: ModelElementImpl, OEmbed
{
  public DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get => (String?)OpenXmlElement?.OEmbedUrl?.Value;
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
    get => (String?)OpenXmlElement?.MediaType?.Value;
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
    get => (Boolean?)OpenXmlElement?.PicLocksAutoForOEmbed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PicLocksAutoForOEmbed = (System.Boolean?)value;
    }
  }
  
}
