namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualGroupProperties Class.
/// </summary>
public static class NonVisualGroupPropertiesConverter
{
  /// <summary>
  /// isLegacyGroup, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetIsLegacyGroup(DXO13D.NonVisualGroupProperties openXmlElement)
  {
    return openXmlElement?.IsLegacyGroup?.Value;
  }
  
  private static bool CmpIsLegacyGroup(DXO13D.NonVisualGroupProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.IsLegacyGroup?.Value == value) return true;
    diffs?.Add(objName, "IsLegacyGroup", openXmlElement?.IsLegacyGroup?.Value, value);
    return false;
  }
  
  private static void SetIsLegacyGroup(DXO13D.NonVisualGroupProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsLegacyGroup = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.IsLegacyGroup = null;
  }
  
  public static DocumentModel.Drawings.NonVisualGroupProperties? CreateModelElement(DXO13D.NonVisualGroupProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualGroupProperties();
      value.IsLegacyGroup = GetIsLegacyGroup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13D.NonVisualGroupProperties? openXmlElement, DMD.NonVisualGroupProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIsLegacyGroup(openXmlElement, value.IsLegacyGroup, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.NonVisualGroupProperties value)
    where OpenXmlElementType: DXO13D.NonVisualGroupProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13D.NonVisualGroupProperties openXmlElement, DMD.NonVisualGroupProperties value)
  {
    SetIsLegacyGroup(openXmlElement, value?.IsLegacyGroup);
  }
}
