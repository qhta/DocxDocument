namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PictureAttributionSourceURL Class.
/// </summary>
public static class PictureAttributionSourceURLConverter
{
  /// <summary>
  /// id, this property is only available in Office 2019 and later.
  /// </summary>
  private static String? GetId(DXO2019Draw.PictureAttributionSourceURL openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2019Draw.PictureAttributionSourceURL openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXO2019Draw.PictureAttributionSourceURL openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMDraws.PictureAttributionSourceURL? CreateModelElement(DXO2019Draw.PictureAttributionSourceURL? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.PictureAttributionSourceURL();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2019Draw.PictureAttributionSourceURL? openXmlElement, DMDraws.PictureAttributionSourceURL? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PictureAttributionSourceURL? value)
    where OpenXmlElementType: DXO2019Draw.PictureAttributionSourceURL, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
