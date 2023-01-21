namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Graphic Object.
/// </summary>
public static class GraphicConverter
{
  /// <summary>
  /// Graphic Object Data.
  /// </summary>
  private static DMDraws.GraphicData? GetGraphicData(DXDraw.Graphic openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GraphicData>();
    if (itemElement != null)
      return DMXDraws.GraphicDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGraphicData(DXDraw.Graphic openXmlElement, DMDraws.GraphicData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GraphicData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GraphicDataConverter.CreateOpenXmlElement<DXDraw.GraphicData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.Graphic? CreateModelElement(DXDraw.Graphic? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Graphic();
      value.GraphicData = GetGraphicData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Graphic? value)
    where OpenXmlElementType: DXDraw.Graphic, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGraphicData(openXmlElement, value?.GraphicData);
      return openXmlElement;
    }
    return default;
  }
}
