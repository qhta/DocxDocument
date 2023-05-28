namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PictureAttributionSourceURL Class.
/// </summary>
public static class PictureAttributionSourceURLConverter
{
  /// <summary>
  /// id, this property is only available in Office 2019 and later.
  /// </summary>
  private static String? GetId(DXO19D.PictureAttributionSourceURL openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO19D.PictureAttributionSourceURL openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO19D.PictureAttributionSourceURL openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMD.PictureAttributionSourceURL? CreateModelElement(DXO19D.PictureAttributionSourceURL? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.PictureAttributionSourceURL();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO19D.PictureAttributionSourceURL? openXmlElement, DMD.PictureAttributionSourceURL? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.PictureAttributionSourceURL value)
    where OpenXmlElementType: DXO19D.PictureAttributionSourceURL, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO19D.PictureAttributionSourceURL openXmlElement, DMD.PictureAttributionSourceURL value)
  {
    SetId(openXmlElement, value?.Id);
  }
}
