namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Adjust Handles.
/// </summary>
public static class AdjustHandleListConverter
{
  private static DMDraws.AdjustHandleXY? GetAdjustHandleXY(DXDraw.AdjustHandleList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.AdjustHandleXY>();
    if (element != null)
      return DMXDraws.AdjustHandleXYConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAdjustHandleXY(DXDraw.AdjustHandleList openXmlElement, DMDraws.AdjustHandleXY? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AdjustHandleXYConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AdjustHandleXY>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAdjustHandleXY(DXDraw.AdjustHandleList openXmlElement, DMDraws.AdjustHandleXY? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AdjustHandleXY>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AdjustHandleXYConverter.CreateOpenXmlElement<DXDraw.AdjustHandleXY>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.AdjustHandlePolar? GetAdjustHandlePolar(DXDraw.AdjustHandleList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.AdjustHandlePolar>();
    if (element != null)
      return DMXDraws.AdjustHandlePolarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAdjustHandlePolar(DXDraw.AdjustHandleList openXmlElement, DMDraws.AdjustHandlePolar? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AdjustHandlePolarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AdjustHandlePolar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAdjustHandlePolar(DXDraw.AdjustHandleList openXmlElement, DMDraws.AdjustHandlePolar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AdjustHandlePolar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AdjustHandlePolarConverter.CreateOpenXmlElement<DXDraw.AdjustHandlePolar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.AdjustHandleList? CreateModelElement(DXDraw.AdjustHandleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AdjustHandleList();
      value.AdjustHandleXY = GetAdjustHandleXY(openXmlElement);
      value.AdjustHandlePolar = GetAdjustHandlePolar(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.AdjustHandleList? openXmlElement, DMDraws.AdjustHandleList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAdjustHandleXY(openXmlElement, value.AdjustHandleXY, diffs, objName))
        ok = false;
      if (!CmpAdjustHandlePolar(openXmlElement, value.AdjustHandlePolar, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AdjustHandleList? value)
    where OpenXmlElementType: DXDraw.AdjustHandleList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAdjustHandleXY(openXmlElement, value?.AdjustHandleXY);
      SetAdjustHandlePolar(openXmlElement, value?.AdjustHandlePolar);
      return openXmlElement;
    }
    return default;
  }
}
