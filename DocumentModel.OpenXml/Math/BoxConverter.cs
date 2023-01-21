namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Box Function.
/// </summary>
public static class BoxConverter
{
  /// <summary>
  /// Box Properties.
  /// </summary>
  private static DMMath.BoxProperties? GetBoxProperties(DXMath.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.BoxProperties>();
    if (itemElement != null)
      return DMXMath.BoxPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBoxProperties(DXMath.Box openXmlElement, DMMath.BoxProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BoxProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BoxPropertiesConverter.CreateOpenXmlElement<DXMath.BoxProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      return DMXMath.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBase(DXMath.Box openXmlElement, DMMath.Base? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BaseConverter.CreateOpenXmlElement<DXMath.Base>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.Box? CreateModelElement(DXMath.Box? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Box();
      value.BoxProperties = GetBoxProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Box? value)
    where OpenXmlElementType: DXMath.Box, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBoxProperties(openXmlElement, value?.BoxProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
