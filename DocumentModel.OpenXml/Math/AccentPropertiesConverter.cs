namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Accent Properties.
/// </summary>
public static class AccentPropertiesConverter
{
  /// <summary>
  /// Accent Character.
  /// </summary>
  private static String? GetAccentChar(DXMath.AccentProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXMath.AccentChar>()?.Val);
  }
  
  private static bool CmpAccentChar(DXMath.AccentProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXMath.AccentChar>()?.Val, value, diffs, objName, "AccentChar");
  }
  
  private static void SetAccentChar(DXMath.AccentProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXMath.AccentChar>(openXmlElement, value);
  }
  
  /// <summary>
  /// Control Properties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.AccentProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (element != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXMath.AccentProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXMath.AccentProperties openXmlElement, DMMath.ControlProperties? value)
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
  
  public static DMMath.AccentProperties? CreateModelElement(DXMath.AccentProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.AccentProperties();
      value.AccentChar = GetAccentChar(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.AccentProperties? openXmlElement, DMMath.AccentProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAccentChar(openXmlElement, value.AccentChar, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, value.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.AccentProperties value)
    where OpenXmlElementType: DXMath.AccentProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.AccentProperties openXmlElement, DMMath.AccentProperties value)
  {
    SetAccentChar(openXmlElement, value?.AccentChar);
    SetControlProperties(openXmlElement, value?.ControlProperties);
  }
}
