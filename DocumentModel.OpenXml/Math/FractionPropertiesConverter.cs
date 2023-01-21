namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Fraction Properties.
/// </summary>
public static class FractionPropertiesConverter
{
  /// <summary>
  /// Fraction type.
  /// </summary>
  private static DMMath.FractionKind? GetFractionType(DXMath.FractionProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.FractionType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.FractionTypeValues, DMMath.FractionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetFractionType(DXMath.FractionProperties openXmlElement, DMMath.FractionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.FractionType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.FractionType, DocumentFormat.OpenXml.Math.FractionTypeValues, DMMath.FractionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.FractionProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlProperties(DXMath.FractionProperties openXmlElement, DMMath.ControlProperties? value)
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
  
  public static DMMath.FractionProperties? CreateModelElement(DXMath.FractionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.FractionProperties();
      value.FractionType = GetFractionType(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.FractionProperties? value)
    where OpenXmlElementType: DXMath.FractionProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFractionType(openXmlElement, value?.FractionType);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
