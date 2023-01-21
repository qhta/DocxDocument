namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Line Style List.
/// </summary>
public static class LineStyleListConverter
{
  private static DMDraws.Outline? GetOutline(DXDraw.LineStyleList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Outline>();
    if (itemElement != null)
      return DMXDraws.OutlineConverter.CreateModelElement(itemElement);
    return null;
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
