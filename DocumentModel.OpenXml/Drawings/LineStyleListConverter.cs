namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Line Style List.
/// </summary>
public static class LineStyleListConverter
{
  private static DMDraws.Outline? GetOutline(DXDraw.LineStyleList openXmlElement)
  {
    return DMXDraws.OutlineConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Outline>());
  }
  
  private static bool CmpOutline(DXDraw.LineStyleList openXmlElement, DMDraws.Outline? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OutlineConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Outline>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOutline(DXDraw.LineStyleList openXmlElement, DMDraws.Outline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.OutlineConverter.CreateOpenXmlElement<DXDraw.Outline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.LineStyleList? CreateModelElement(DXDraw.LineStyleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.LineStyleList();
      value.Outline = GetOutline(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.LineStyleList? openXmlElement, DMDraws.LineStyleList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOutline(openXmlElement, value.Outline, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LineStyleList? value)
    where OpenXmlElementType: DXDraw.LineStyleList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOutline(openXmlElement, value?.Outline);
      return openXmlElement;
    }
    return default;
  }
}
