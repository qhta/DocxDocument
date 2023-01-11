namespace DocumentModel.OpenXml.Wordprocessing.OEmbed;

/// <summary>
/// Defines the OEmbed Class.
/// </summary>
public static class OEmbedConverter
{
  /// <summary>
  /// oEmbedUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  public static String? GetOEmbedUrl(DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed? openXmlElement)
  {
    return openXmlElement?.OEmbedUrl?.Value;
  }
  
  public static void SetOEmbedUrl(DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OEmbedUrl = new StringValue { Value = value };
      else
        openXmlElement.OEmbedUrl = null;
  }
  
  /// <summary>
  /// mediaType, this property is only available in Microsoft365 and later.
  /// </summary>
  public static String? GetMediaType(DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed? openXmlElement)
  {
    return openXmlElement?.MediaType?.Value;
  }
  
  public static void SetMediaType(DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MediaType = new StringValue { Value = value };
      else
        openXmlElement.MediaType = null;
  }
  
  /// <summary>
  /// picLocksAutoForOEmbed, this property is only available in Microsoft365 and later.
  /// </summary>
  public static Boolean? GetPicLocksAutoForOEmbed(DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed? openXmlElement)
  {
    return openXmlElement?.PicLocksAutoForOEmbed?.Value;
  }
  
  public static void SetPicLocksAutoForOEmbed(DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PicLocksAutoForOEmbed = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.PicLocksAutoForOEmbed = null;
  }
  
  public static DocumentModel.Wordprocessing.OEmbed.OEmbed? CreateModelElement(DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.OEmbed.OEmbed();
      value.OEmbedUrl = GetOEmbedUrl(openXmlElement);
      value.MediaType = GetMediaType(openXmlElement);
      value.PicLocksAutoForOEmbed = GetPicLocksAutoForOEmbed(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.OEmbed.OEmbed? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
