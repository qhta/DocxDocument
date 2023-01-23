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
      return openXmlElement?.GetFirstChild<DXMath.AccentChar>()?.Val?.Value;
  }
  
  private static bool CmpAccentChar(DXMath.AccentProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXMath.AccentChar>()?.Val?.Value == value;
  }
  
  private static void SetAccentChar(DXMath.AccentProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.AccentChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.AccentChar { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Control Properties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.AccentProperties openXmlElement)
  {
    return DMXMath.ControlPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.ControlProperties>());
  }
  
  private static bool CmpControlProperties(DXMath.AccentProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.AccentProperties? value)
    where OpenXmlElementType: DXMath.AccentProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAccentChar(openXmlElement, value?.AccentChar);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
