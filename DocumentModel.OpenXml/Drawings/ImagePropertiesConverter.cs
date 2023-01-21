namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ImageProperties Class.
/// </summary>
public static class ImagePropertiesConverter
{
  /// <summary>
  /// ImageLayer.
  /// </summary>
  private static DMDraws.ImageLayer? GetImageLayer(DXO2010Draw.ImageProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ImageLayer>();
    if (itemElement != null)
      return DMXDraws.ImageLayerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetImageLayer(DXO2010Draw.ImageProperties openXmlElement, DMDraws.ImageLayer? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ImageLayer>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ImageLayerConverter.CreateOpenXmlElement<DXO2010Draw.ImageLayer>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.ImageProperties? CreateModelElement(DXO2010Draw.ImageProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ImageProperties();
      value.ImageLayer = GetImageLayer(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ImageProperties? value)
    where OpenXmlElementType: DXO2010Draw.ImageProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetImageLayer(openXmlElement, value?.ImageLayer);
      return openXmlElement;
    }
    return default;
  }
}
