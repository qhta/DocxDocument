namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Adjust Handles.
/// </summary>
public static class AdjustHandleListConverter
{
  private static DMD.AdjustHandleXY? GetAdjustHandleXY(DXD.AdjustHandleList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AdjustHandleXY>();
    if (element != null)
      return DMXD.AdjustHandleXYConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAdjustHandleXY(DXD.AdjustHandleList openXmlElement, DMD.AdjustHandleXY? value, DiffList? diffs, string? objName)
  {
    return DMXD.AdjustHandleXYConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AdjustHandleXY>(), value, diffs, objName);
  }
  
  private static void SetAdjustHandleXY(DXD.AdjustHandleList openXmlElement, DMD.AdjustHandleXY? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AdjustHandleXY>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AdjustHandleXYConverter.CreateOpenXmlElement<DXD.AdjustHandleXY>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.AdjustHandlePolar? GetAdjustHandlePolar(DXD.AdjustHandleList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AdjustHandlePolar>();
    if (element != null)
      return DMXD.AdjustHandlePolarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAdjustHandlePolar(DXD.AdjustHandleList openXmlElement, DMD.AdjustHandlePolar? value, DiffList? diffs, string? objName)
  {
    return DMXD.AdjustHandlePolarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AdjustHandlePolar>(), value, diffs, objName);
  }
  
  private static void SetAdjustHandlePolar(DXD.AdjustHandleList openXmlElement, DMD.AdjustHandlePolar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AdjustHandlePolar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AdjustHandlePolarConverter.CreateOpenXmlElement<DXD.AdjustHandlePolar>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.AdjustHandleList? CreateModelElement(DXD.AdjustHandleList? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.AdjustHandleList? openXmlElement, DMD.AdjustHandleList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.AdjustHandleList value)
    where OpenXmlElementType: DXD.AdjustHandleList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.AdjustHandleList openXmlElement, DMD.AdjustHandleList value)
  {
    SetAdjustHandleXY(openXmlElement, value?.AdjustHandleXY);
    SetAdjustHandlePolar(openXmlElement, value?.AdjustHandlePolar);
  }
}
