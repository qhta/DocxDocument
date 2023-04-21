namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ObjectProperties Class.
/// </summary>
public static class ObjectPropertiesConverter
{
  /// <summary>
  /// objectId, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DXO13D.ObjectProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO13D.ObjectProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO13D.ObjectProperties openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// isActiveX, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetIsActiveX(DXO13D.ObjectProperties openXmlElement)
  {
    return openXmlElement?.IsActiveX?.Value;
  }
  
  private static bool CmpIsActiveX(DXO13D.ObjectProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IsActiveX?.Value == value) return true;
    diffs?.Add(objName, "IsActiveX", openXmlElement?.IsActiveX?.Value, value);
    return false;
  }
  
  private static void SetIsActiveX(DXO13D.ObjectProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsActiveX = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.IsActiveX = null;
  }
  
  /// <summary>
  /// linkType, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetLinkType(DXO13D.ObjectProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.LinkType);
  }
  
  private static bool CmpLinkType(DXO13D.ObjectProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LinkType, value, diffs, objName, "LinkType");
  }
  
  private static void SetLinkType(DXO13D.ObjectProperties openXmlElement, String? value)
  {
    openXmlElement.LinkType = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.ObjectProperties? CreateModelElement(DXO13D.ObjectProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ObjectProperties();
      value.Id = GetId(openXmlElement);
      value.IsActiveX = GetIsActiveX(openXmlElement);
      value.LinkType = GetLinkType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13D.ObjectProperties? openXmlElement, DMD.ObjectProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpIsActiveX(openXmlElement, value.IsActiveX, diffs, objName))
        ok = false;
      if (!CmpLinkType(openXmlElement, value.LinkType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ObjectProperties value)
    where OpenXmlElementType: DXO13D.ObjectProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13D.ObjectProperties openXmlElement, DMD.ObjectProperties value)
  {
    SetId(openXmlElement, value?.Id);
    SetIsActiveX(openXmlElement, value?.IsActiveX);
    SetLinkType(openXmlElement, value?.LinkType);
  }
}
