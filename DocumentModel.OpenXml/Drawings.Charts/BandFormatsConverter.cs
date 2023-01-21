namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Band Formats.
/// </summary>
public static class BandFormatsConverter
{
  private static Collection<DMDrawsCharts.BandFormat> GetItems(DXDrawCharts.BandFormats openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BandFormat>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BandFormat>())
    {
      var newItem = DMXDrawsCharts.BandFormatConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXDrawCharts.BandFormats openXmlElement, Collection<DMDrawsCharts.BandFormat>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.BandFormat>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.BandFormatConverter.CreateOpenXmlElement<DXDrawCharts.BandFormat>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.BandFormats? CreateModelElement(DXDrawCharts.BandFormats? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BandFormats();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BandFormats? value)
    where OpenXmlElementType: DXDrawCharts.BandFormats, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
