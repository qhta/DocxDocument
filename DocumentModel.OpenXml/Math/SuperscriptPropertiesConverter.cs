namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Superscript Properties.
/// </summary>
public static class SuperscriptPropertiesConverter
{
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.SuperscriptProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.SuperscriptProperties? value)
    where OpenXmlElementType: DXMath.SuperscriptProperties, new()
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
