namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Graphic Object.
/// </summary>
public static class GraphicConverter
{
  /// <summary>
  /// Graphic Object Data.
  /// </summary>
  private static DMD.GraphicData? GetGraphicData(DXD.Graphic openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.GraphicData>();
    if (element != null)
      return DMXD.GraphicDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphicData(DXD.Graphic openXmlElement, DMD.GraphicData? value, DiffList? diffs, string? objName)
  {
    return DMXD.GraphicDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.GraphicData>(), value, diffs, objName);
  }
  
  private static void SetGraphicData(DXD.Graphic openXmlElement, DMD.GraphicData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GraphicData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GraphicDataConverter.CreateOpenXmlElement<DXD.GraphicData>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Graphic? CreateModelElement(DXD.Graphic? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Graphic();
      value.GraphicData = GetGraphicData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Graphic? openXmlElement, DMD.Graphic? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Graphic value)
    where OpenXmlElementType: DXD.Graphic, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Graphic openXmlElement, DMD.Graphic value)
  {
    SetGraphicData(openXmlElement, value?.GraphicData);
  }
}
