namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Superscript Properties converter from/to OpenXml.
///</summary>
public static class SuperscriptPropertiesConverter
{
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.SuperscriptProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (element != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXMath.SuperscriptProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXMath.SuperscriptProperties openXmlElement, DMMath.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ControlPropertiesConverter.CreateOpenXmlElement<DXMath.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.SuperscriptProperties? CreateModelElement(DXMath.SuperscriptProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.SuperscriptProperties();
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.SuperscriptProperties? openXmlElement, DMMath.SuperscriptProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpControlProperties(openXmlElement, value.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.SuperscriptProperties value)
    where OpenXmlElementType: DXMath.SuperscriptProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.SuperscriptProperties openXmlElement, DMMath.SuperscriptProperties value)
  {
    SetControlProperties(openXmlElement, value?.ControlProperties);
  }
}
