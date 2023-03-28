namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Bar Properties converter from/to OpenXml.
///</summary>
public static class BarPropertiesConverter
{
  /// <summary>
  /// Position (Bar).
  /// </summary>
  private static DMMath.VerticalJustificationKind? GetPosition(DXMath.BarProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMMath.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXMath.Position>()?.Val?.Value);
  }
  
  private static bool CmpPosition(DXMath.BarProperties openXmlElement, DMMath.VerticalJustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMMath.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXMath.Position>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetPosition(DXMath.BarProperties openXmlElement, DMMath.VerticalJustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Position>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMMath.VerticalJustificationKind>(itemElement, (DMMath.VerticalJustificationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.Position, DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMMath.VerticalJustificationKind>((DMMath.VerticalJustificationKind)value));
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.BarProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (element != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXMath.BarProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXMath.BarProperties openXmlElement, DMMath.ControlProperties? value)
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
  
  public static DMMath.BarProperties? CreateModelElement(DXMath.BarProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.BarProperties();
      value.Position = GetPosition(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.BarProperties? openXmlElement, DMMath.BarProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, value.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.BarProperties value)
    where OpenXmlElementType: DXMath.BarProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.BarProperties openXmlElement, DMMath.BarProperties value)
  {
    SetPosition(openXmlElement, value?.Position);
    SetControlProperties(openXmlElement, value?.ControlProperties);
  }
}
