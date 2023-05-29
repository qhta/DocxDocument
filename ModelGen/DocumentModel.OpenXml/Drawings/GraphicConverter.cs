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
    var element = openXmlElement?.GetFirstChild<DXDraw.GraphicData>();
    if (element != null)
      return DMXDraws.GraphicDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphicData(DXDraw.Graphic openXmlElement, DMDraws.GraphicData? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GraphicDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.GraphicData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.Graphic? CreateModelElement(DXDraw.Graphic? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Graphic();
      value.GraphicData = GetGraphicData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Graphic? openXmlElement, DMDraws.Graphic? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGraphicData(openXmlElement, value.GraphicData, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Graphic value)
    where OpenXmlElementType: DXDraw.Graphic, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.Graphic openXmlElement, DMDraws.Graphic value)
  {
    SetGraphicData(openXmlElement, value?.GraphicData);
  }
}
