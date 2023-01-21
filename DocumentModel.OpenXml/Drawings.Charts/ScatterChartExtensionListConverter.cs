namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterChartExtensionList Class.
/// </summary>
public static class ScatterChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.ScatterChartExtension> GetScatterChartExtensions(DXDrawCharts.ScatterChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.ScatterChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.ScatterChartExtension>())
    {
      var newItem = DMXDrawsCharts.ScatterChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetScatterChartExtensions(DXDrawCharts.ScatterChartExtensionList openXmlElement, Collection<DMDrawsCharts.ScatterChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.ScatterChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.ScatterChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.ScatterChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.ScatterChartExtensionList? CreateModelElement(DXDrawCharts.ScatterChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ScatterChartExtensionList();
      value.ScatterChartExtensions = GetScatterChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ScatterChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.ScatterChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetScatterChartExtensions(openXmlElement, value?.ScatterChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
