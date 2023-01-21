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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.AccentChar>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.Position>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMMath.VerticalJustificationKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXMath.VerticalJustification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMMath.VerticalJustificationKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
