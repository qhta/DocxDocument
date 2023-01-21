namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Tab List.
/// </summary>
public static class TabStopListConverter
{
  private static Collection<DMDraws.TabStop> GetTabStops(DXDraw.TabStopList openXmlElement)
  {
    var collection = new Collection<DMDraws.TabStop>();
    foreach (var item in openXmlElement.Elements<DXDraw.TabStop>())
    {
      var newItem = DMXDraws.TabStopConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetTabStops(DXDraw.TabStopList openXmlElement, Collection<DMDraws.TabStop>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.TabStop>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.TabStopConverter.CreateOpenXmlElement<DXDraw.TabStop>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.TabStopList? CreateModelElement(DXDraw.TabStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.TabStopList();
      value.TabStops = GetTabStops(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.TabStopList? value)
    where OpenXmlElementType: DXDraw.TabStopList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTabStops(openXmlElement, value?.TabStops);
      return openXmlElement;
    }
    return default;
  }
}
