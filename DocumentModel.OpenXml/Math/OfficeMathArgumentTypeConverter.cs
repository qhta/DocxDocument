namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Defines the OfficeMathArgumentType Class.
/// </summary>
public static class OfficeMathArgumentTypeConverter
{
  /// <summary>
  /// Argument Properties.
  /// </summary>
  private static DMMath.ArgumentProperties? GetArgumentProperties(DXMath.OfficeMathArgumentType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ArgumentProperties>();
    if (itemElement != null)
      return DMXMath.ArgumentPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArgumentProperties(DXMath.OfficeMathArgumentType openXmlElement, DMMath.ArgumentProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ArgumentProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ArgumentPropertiesConverter.CreateOpenXmlElement<DXMath.ArgumentProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.OfficeMathArgumentType? CreateModelElement(DXMath.OfficeMathArgumentType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.OfficeMathArgumentType();
      value.ArgumentProperties = GetArgumentProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.OfficeMathArgumentType? value)
    where OpenXmlElementType: DXMath.OfficeMathArgumentType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetArgumentProperties(openXmlElement, value?.ArgumentProperties);
      return openXmlElement;
    }
    return default;
  }
}
