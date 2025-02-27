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
    return StringValueConverter.GetValue(openXmlElement?.OEmbedUrl);
  }
  
  private static bool CmpOEmbedUrl(DXOWY2020OEmb.OEmbed openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OEmbedUrl, value, diffs, objName, "OEmbedUrl");
  }
  
  private static void SetOEmbedUrl(DXOWY2020OEmb.OEmbed openXmlElement, String? value)
  {
    openXmlElement.OEmbedUrl = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// mediaType, this property is only available in Microsoft365 and later.
  /// </summary>
  private static String? GetMediaType(DXOWY2020OEmb.OEmbed openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MediaType);
  }
  
  private static bool CmpMediaType(DXOWY2020OEmb.OEmbed openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MediaType, value, diffs, objName, "MediaType");
  }
  
  private static void SetMediaType(DXOWY2020OEmb.OEmbed openXmlElement, String? value)
  {
    openXmlElement.MediaType = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// picLocksAutoForOEmbed, this property is only available in Microsoft365 and later.
  /// </summary>
  private static Boolean? GetPicLocksAutoForOEmbed(DXOWY2020OEmb.OEmbed openXmlElement)
  {
    return openXmlElement?.PicLocksAutoForOEmbed?.Value;
  }
  
  private static bool CmpPicLocksAutoForOEmbed(DXOWY2020OEmb.OEmbed openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PicLocksAutoForOEmbed?.Value == value) return true;
    diffs?.Add(objName, "PicLocksAutoForOEmbed", openXmlElement?.PicLocksAutoForOEmbed?.Value, value);
    return false;
  }
  
  private static void SetPicLocksAutoForOEmbed(DXOWY2020OEmb.OEmbed openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PicLocksAutoForOEmbed = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.PicLocksAutoForOEmbed = null;
  }
  
  public static DocumentModel.Wordprocessing.OEmbed.OEmbed? CreateModelElement(DXOWY2020OEmb.OEmbed? openXmlElement)
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
  
  public static bool CompareModelElement(DXOWY2020OEmb.OEmbed? openXmlElement, DMWOEmb.OEmbed? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOEmbedUrl(openXmlElement, value.OEmbedUrl, diffs, objName))
        ok = false;
      if (!CmpMediaType(openXmlElement, value.MediaType, diffs, objName))
        ok = false;
      if (!CmpPicLocksAutoForOEmbed(openXmlElement, value.PicLocksAutoForOEmbed, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWOEmb.OEmbed value)
    where OpenXmlElementType: DXOWY2020OEmb.OEmbed, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOWY2020OEmb.OEmbed openXmlElement, DMWOEmb.OEmbed value)
  {
    SetOEmbedUrl(openXmlElement, value?.OEmbedUrl);
    SetMediaType(openXmlElement, value?.MediaType);
    SetPicLocksAutoForOEmbed(openXmlElement, value?.PicLocksAutoForOEmbed);
  }
}
