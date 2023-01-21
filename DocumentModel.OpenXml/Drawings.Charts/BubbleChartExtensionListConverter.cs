namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartExtensionList Class.
/// </summary>
public static class BubbleChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.BubbleChartExtension> GetBubbleChartExtensions(DXDrawCharts.BubbleChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BubbleChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BubbleChartExtension>())
    {
      var newItem = DMXDrawsCharts.BubbleChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetBubbleChartExtensions(DXDrawCharts.BubbleChartExtensionList openXmlElement, Collection<DMDrawsCharts.BubbleChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.BubbleChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.BubbleChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.BubbleChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.BubbleChartExtensionList? CreateModelElement(DXDrawCharts.BubbleChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BubbleChartExtensionList();
      value.BubbleChartExtensions = GetBubbleChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BubbleChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.BubbleChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBubbleChartExtensions(openXmlElement, value?.BubbleChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
