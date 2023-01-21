namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LinePropertiesExtension Class.
/// </summary>
public static class LinePropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.LinePropertiesExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDraw.LinePropertiesExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDraws.LineSketchStyleProperties? GetLineSketchStyleProperties(DXDraw.LinePropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DrawSketchyShps.LineSketchStyleProperties>();
    if (itemElement != null)
      return DMXDraws.LineSketchStylePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineSketchStyleProperties(DXDraw.LinePropertiesExtension openXmlElement, DMDraws.LineSketchStyleProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchStyleProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineSketchStylePropertiesConverter.CreateOpenXmlElement<DXO2021DrawSketchyShps.LineSketchStyleProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.LinePropertiesExtension? CreateModelElement(DXDraw.LinePropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.LinePropertiesExtension();
      value.Uri = GetUri(openXmlElement);
      value.LineSketchStyleProperties = GetLineSketchStyleProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LinePropertiesExtension? value)
    where OpenXmlElementType: DXDraw.LinePropertiesExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetLineSketchStyleProperties(openXmlElement, value?.LineSketchStyleProperties);
      return openXmlElement;
    }
    return default;
  }
}
