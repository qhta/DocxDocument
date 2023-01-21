namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Bar Properties.
/// </summary>
public static class BarPropertiesConverter
{
  /// <summary>
  /// Position (Bar).
  /// </summary>
  private static DMMath.VerticalJustificationKind? GetPosition(DXMath.BarProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Position>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DMMath.VerticalJustificationKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetPosition(DXMath.BarProperties openXmlElement, DMMath.VerticalJustificationKind? value)
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
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.BarProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.BarProperties? value)
    where OpenXmlElementType: DXMath.BarProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPosition(openXmlElement, value?.Position);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
