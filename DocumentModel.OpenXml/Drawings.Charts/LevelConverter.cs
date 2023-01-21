namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Level.
/// </summary>
public static class LevelConverter
{
  private static Collection<DMDrawsCharts.StringPoint> GetStringPoints(DXDrawCharts.Level openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.StringPoint>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.StringPoint>())
    {
      var newItem = DMXDrawsCharts.StringPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetStringPoints(DXDrawCharts.Level openXmlElement, Collection<DMDrawsCharts.StringPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.StringPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.StringPointConverter.CreateOpenXmlElement<DXDrawCharts.StringPoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.Level? CreateModelElement(DXDrawCharts.Level? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Level();
      value.StringPoints = GetStringPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Level? value)
    where OpenXmlElementType: DXDrawCharts.Level, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStringPoints(openXmlElement, value?.StringPoints);
      return openXmlElement;
    }
    return default;
  }
}
