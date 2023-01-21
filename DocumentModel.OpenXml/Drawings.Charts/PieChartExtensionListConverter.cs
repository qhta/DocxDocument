namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PieChartExtensionList Class.
/// </summary>
public static class PieChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.PieChartExtension> GetPieChartExtensions(DXDrawCharts.PieChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.PieChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.PieChartExtension>())
    {
      var newItem = DMXDrawsCharts.PieChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetPieChartExtensions(DXDrawCharts.PieChartExtensionList openXmlElement, Collection<DMDrawsCharts.PieChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.PieChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.PieChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.PieChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.PieChartExtensionList? CreateModelElement(DXDrawCharts.PieChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PieChartExtensionList();
      value.PieChartExtensions = GetPieChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PieChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.PieChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPieChartExtensions(openXmlElement, value?.PieChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
