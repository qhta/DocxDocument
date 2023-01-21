namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Subscript Properties.
/// </summary>
public static class SubscriptPropertiesConverter
{
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.SubscriptProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlProperties(DXMath.SubscriptProperties openXmlElement, DMMath.ControlProperties? value)
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
  
  public static DMMath.SubscriptProperties? CreateModelElement(DXMath.SubscriptProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.SubscriptProperties();
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.SubscriptProperties? value)
    where OpenXmlElementType: DXMath.SubscriptProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
