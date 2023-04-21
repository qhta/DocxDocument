namespace DocumentModel.OpenXml.Wordprocessing.OEmbed;

/// <summary>
/// Defines the OEmbed Class.
/// </summary>
public static class OEmbedConverter
{
  /// <summary>
  /// oEmbedUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  private static String? GetOEmbedUrl(DXOSWY20OE.OEmbed openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OEmbedUrl);
  }
  
  private static bool CmpOEmbedUrl(DXOSWY20OE.OEmbed openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OEmbedUrl, value, diffs, objName, "OEmbedUrl");
  }
  
  private static void SetOEmbedUrl(DXOSWY20OE.OEmbed openXmlElement, String? value)
  {
    openXmlElement.OEmbedUrl = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// mediaType, this property is only available in Microsoft365 and later.
  /// </summary>
  private static String? GetMediaType(DXOSWY20OE.OEmbed openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MediaType);
  }
  
  private static bool CmpMediaType(DXOSWY20OE.OEmbed openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MediaType, value, diffs, objName, "MediaType");
  }
  
  private static void SetMediaType(DXOSWY20OE.OEmbed openXmlElement, String? value)
  {
    openXmlElement.MediaType = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// picLocksAutoForOEmbed, this property is only available in Microsoft365 and later.
  /// </summary>
  private static Boolean? GetPicLocksAutoForOEmbed(DXOSWY20OE.OEmbed openXmlElement)
  {
    return openXmlElement?.PicLocksAutoForOEmbed?.Value;
  }
  
  private static bool CmpPicLocksAutoForOEmbed(DXOSWY20OE.OEmbed openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PicLocksAutoForOEmbed?.Value == value) return true;
    diffs?.Add(objName, "PicLocksAutoForOEmbed", openXmlElement?.PicLocksAutoForOEmbed?.Value, value);
    return false;
  }
  
  private static void SetPicLocksAutoForOEmbed(DXOSWY20OE.OEmbed openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PicLocksAutoForOEmbed = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.PicLocksAutoForOEmbed = null;
  }
  
  public static DMW.OEmbed.OEmbed? CreateModelElement(DXOSWY20OE.OEmbed? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.OEmbed.OEmbed();
      value.OEmbedUrl = GetOEmbedUrl(openXmlElement);
      value.MediaType = GetMediaType(openXmlElement);
      value.PicLocksAutoForOEmbed = GetPicLocksAutoForOEmbed(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOSWY20OE.OEmbed? openXmlElement, DMWOE.OEmbed? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWOE.OEmbed value)
    where OpenXmlElementType: DXOSWY20OE.OEmbed, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOSWY20OE.OEmbed openXmlElement, DMWOE.OEmbed value)
  {
    SetOEmbedUrl(openXmlElement, value?.OEmbedUrl);
    SetMediaType(openXmlElement, value?.MediaType);
    SetPicLocksAutoForOEmbed(openXmlElement, value?.PicLocksAutoForOEmbed);
  }
}
