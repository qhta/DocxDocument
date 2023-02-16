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
    var element = openXmlElement?.GetFirstChild<DXO2010Draw.ImageLayer>();
    if (element != null)
      return DMXDraws.ImageLayerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageLayer(DXO2010Draw.ImageProperties openXmlElement, DMDraws.ImageLayer? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ImageLayerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010Draw.ImageLayer>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.ImageProperties? CreateModelElement(DXO2010Draw.ImageProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ImageProperties();
      value.ImageLayer = GetImageLayer(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ImageProperties? openXmlElement, DMDraws.ImageProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpImageLayer(openXmlElement, value.ImageLayer, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
