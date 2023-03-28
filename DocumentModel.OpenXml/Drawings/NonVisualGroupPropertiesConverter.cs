namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualGroupProperties Class converter from/to OpenXml.
///</summary>
public static class NonVisualGroupPropertiesConverter
{
  /// <summary>
  /// isLegacyGroup, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetIsLegacyGroup(DXO2013Draw.NonVisualGroupProperties openXmlElement)
  {
    return openXmlElement?.IsLegacyGroup?.Value;
  }
  
  private static bool CmpIsLegacyGroup(DXO2013Draw.NonVisualGroupProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IsLegacyGroup?.Value == value) return true;
    diffs?.Add(objName, "IsLegacyGroup", openXmlElement?.IsLegacyGroup?.Value, value);
    return false;
  }
  
  private static void SetIsLegacyGroup(DXO2013Draw.NonVisualGroupProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsLegacyGroup = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.IsLegacyGroup = null;
  }
  
  public static DocumentModel.Drawings.NonVisualGroupProperties? CreateModelElement(DXO2013Draw.NonVisualGroupProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualGroupProperties();
      value.IsLegacyGroup = GetIsLegacyGroup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013Draw.NonVisualGroupProperties? openXmlElement, DMDraws.NonVisualGroupProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIsLegacyGroup(openXmlElement, value.IsLegacyGroup, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualGroupProperties value)
    where OpenXmlElementType: DXO2013Draw.NonVisualGroupProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013Draw.NonVisualGroupProperties openXmlElement, DMDraws.NonVisualGroupProperties value)
  {
    SetIsLegacyGroup(openXmlElement, value?.IsLegacyGroup);
  }
}
