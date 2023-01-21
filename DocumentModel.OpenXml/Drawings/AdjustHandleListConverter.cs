namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Adjust Handles.
/// </summary>
public static class AdjustHandleListConverter
{
  private static DMDraws.AdjustHandleXY? GetAdjustHandleXY(DXDraw.AdjustHandleList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AdjustHandleXY>();
    if (itemElement != null)
      return DMXDraws.AdjustHandleXYConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AdjustHandlePolar>();
    if (itemElement != null)
      return DMXDraws.AdjustHandlePolarConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDraws.AdjustHandleList? CreateModelElement(DXDraw.AdjustHandleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.AdjustHandleList();
      value.AdjustHandleXY = GetAdjustHandleXY(openXmlElement);
      value.AdjustHandlePolar = GetAdjustHandlePolar(openXmlElement);
      return value;
    }
    return null;
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
