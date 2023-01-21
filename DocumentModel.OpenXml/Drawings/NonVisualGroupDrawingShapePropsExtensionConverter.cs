namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtension Class.
/// </summary>
public static class NonVisualGroupDrawingShapePropsExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDraws.NonVisualGroupProperties? GetNonVisualGroupProperties(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013Draw.NonVisualGroupProperties>();
    if (itemElement != null)
      return DMXDraws.NonVisualGroupPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualGroupProperties(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement, DMDraws.NonVisualGroupProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013Draw.NonVisualGroupProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.NonVisualGroupPropertiesConverter.CreateOpenXmlElement<DXO2013Draw.NonVisualGroupProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.NonVisualGroupDrawingShapePropsExtension? CreateModelElement(DXDraw.NonVisualGroupDrawingShapePropsExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.NonVisualGroupDrawingShapePropsExtension();
      value.Uri = GetUri(openXmlElement);
      value.NonVisualGroupProperties = GetNonVisualGroupProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualGroupDrawingShapePropsExtension? value)
    where OpenXmlElementType: DXDraw.NonVisualGroupDrawingShapePropsExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetNonVisualGroupProperties(openXmlElement, value?.NonVisualGroupProperties);
      return openXmlElement;
    }
    return default;
  }
}
