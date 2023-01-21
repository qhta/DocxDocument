namespace DocumentModel.OpenXml.Wordprocessing.OEmbed;

/// <summary>
/// Defines the OEmbed Class.
/// </summary>
public static class OEmbedConverter
{
  /// <summary>
  /// oEmbedUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  private static String? GetOEmbedUrl(DXOWY2020OEmb.OEmbed openXmlElement)
  {
    return openXmlElement?.OEmbedUrl?.Value;
  }
  
  private static void SetOEmbedUrl(DXOWY2020OEmb.OEmbed openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OEmbedUrl = new StringValue { Value = value };
    else
      openXmlElement.OEmbedUrl = null;
  }
  
  /// <summary>
  /// mediaType, this property is only available in Microsoft365 and later.
  /// </summary>
  private static String? GetMediaType(DXOWY2020OEmb.OEmbed openXmlElement)
  {
    return openXmlElement?.MediaType?.Value;
  }
  
  private static void SetMediaType(DXOWY2020OEmb.OEmbed openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MediaType = new StringValue { Value = value };
    else
      openXmlElement.MediaType = null;
  }
  
  /// <summary>
  /// picLocksAutoForOEmbed, this property is only available in Microsoft365 and later.
  /// </summary>
  private static Boolean? GetPicLocksAutoForOEmbed(DXOWY2020OEmb.OEmbed openXmlElement)
  {
    return openXmlElement?.PicLocksAutoForOEmbed?.Value;
  }
  
  private static void SetPicLocksAutoForOEmbed(DXOWY2020OEmb.OEmbed openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PicLocksAutoForOEmbed = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.PicLocksAutoForOEmbed = null;
  }
  
  public static DMWOEmb.OEmbed? CreateModelElement(DXOWY2020OEmb.OEmbed? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWOEmb.OEmbed();
      value.OEmbedUrl = GetOEmbedUrl(openXmlElement);
      value.MediaType = GetMediaType(openXmlElement);
      value.PicLocksAutoForOEmbed = GetPicLocksAutoForOEmbed(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWOEmb.OEmbed? value)
    where OpenXmlElementType: DXOWY2020OEmb.OEmbed, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOEmbedUrl(openXmlElement, value?.OEmbedUrl);
      SetMediaType(openXmlElement, value?.MediaType);
      SetPicLocksAutoForOEmbed(openXmlElement, value?.PicLocksAutoForOEmbed);
      return openXmlElement;
    }
    return default;
  }
}
