namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Group-Character Properties.
/// </summary>
public static class GroupCharPropertiesConverter
{
  /// <summary>
  /// Group Character (Grouping Character).
  /// </summary>
  private static String? GetAccentChar(DXMath.GroupCharProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXMath.AccentChar>()?.Val?.Value;
  }
  
  private static bool CmpAccentChar(DXMath.GroupCharProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXMath.AccentChar>()?.Val?.Value == value;
  }
  
  private static void SetAccentChar(DXMath.GroupCharProperties openXmlElement, String? value)
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
  /// Position (Group Character).
  /// </summary>
  private static DMMath.VerticalJustificationKind? GetPosition(DXMath.GroupCharProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMMath.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXMath.Position>()?.Val?.Value);
  }
  
  private static bool CmpPosition(DXMath.GroupCharProperties openXmlElement, DMMath.VerticalJustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMMath.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXMath.Position>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPosition(DXMath.GroupCharProperties openXmlElement, DMMath.VerticalJustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Position>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.Position, DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMMath.VerticalJustificationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Vertical Justification.
  /// </summary>
  private static DMMath.VerticalJustificationKind? GetVerticalJustification(DXMath.GroupCharProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMMath.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXMath.VerticalJustification>()?.Val?.Value);
  }
  
  private static bool CmpVerticalJustification(DXMath.GroupCharProperties openXmlElement, DMMath.VerticalJustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMMath.VerticalJustificationKind>(openXmlElement.GetFirstChild<DXMath.VerticalJustification>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVerticalJustification(DXMath.GroupCharProperties openXmlElement, DMMath.VerticalJustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.VerticalJustification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.VerticalJustification, DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMMath.VerticalJustificationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.GroupCharProperties openXmlElement)
  {
    return DMXMath.ControlPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.ControlProperties>());
  }
  
  private static bool CmpControlProperties(DXMath.GroupCharProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetControlProperties(DXMath.GroupCharProperties openXmlElement, DMMath.ControlProperties? value)
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
  
  public static DMMath.GroupCharProperties? CreateModelElement(DXMath.GroupCharProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.GroupCharProperties();
      value.AccentChar = GetAccentChar(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      value.VerticalJustification = GetVerticalJustification(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.GroupCharProperties? openXmlElement, DMMath.GroupCharProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAccentChar(openXmlElement, value.AccentChar, diffs, objName))
        ok = false;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName))
        ok = false;
      if (!CmpVerticalJustification(openXmlElement, value.VerticalJustification, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, value.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.GroupCharProperties? value)
    where OpenXmlElementType: DXMath.GroupCharProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAccentChar(openXmlElement, value?.AccentChar);
      SetPosition(openXmlElement, value?.Position);
      SetVerticalJustification(openXmlElement, value?.VerticalJustification);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
