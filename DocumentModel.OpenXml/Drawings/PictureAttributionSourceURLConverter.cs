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
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2019Draw.PictureAttributionSourceURL openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXO2019Draw.PictureAttributionSourceURL openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.PictureAttributionSourceURL? CreateModelElement(DXO2019Draw.PictureAttributionSourceURL? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PictureAttributionSourceURL();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PictureAttributionSourceURL value)
    where OpenXmlElementType: DXO2019Draw.PictureAttributionSourceURL, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2019Draw.PictureAttributionSourceURL openXmlElement, DMDraws.PictureAttributionSourceURL value)
  {
    SetId(openXmlElement, value?.Id);
  }
}
