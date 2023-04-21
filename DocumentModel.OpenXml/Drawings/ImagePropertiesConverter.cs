namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ImageProperties Class.
/// </summary>
public static class ImagePropertiesConverter
{
  /// <summary>
  /// ImageLayer.
  /// </summary>
  private static DMD.ImageLayer? GetImageLayer(DXO10D.ImageProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ImageLayer>();
    if (element != null)
      return DMXD.ImageLayerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageLayer(DXO10D.ImageProperties openXmlElement, DMD.ImageLayer? value, DiffList? diffs, string? objName)
  {
    return DMXD.ImageLayerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ImageLayer>(), value, diffs, objName);
  }
  
  private static void SetImageLayer(DXO10D.ImageProperties openXmlElement, DMD.ImageLayer? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ImageLayer>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ImageLayerConverter.CreateOpenXmlElement<DXO10D.ImageLayer>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ImageProperties? CreateModelElement(DXO10D.ImageProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ImageProperties();
      value.ImageLayer = GetImageLayer(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.ImageProperties? openXmlElement, DMD.ImageProperties? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ImageProperties value)
    where OpenXmlElementType: DXO10D.ImageProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ImageProperties openXmlElement, DMD.ImageProperties value)
  {
    SetImageLayer(openXmlElement, value?.ImageLayer);
  }
}
