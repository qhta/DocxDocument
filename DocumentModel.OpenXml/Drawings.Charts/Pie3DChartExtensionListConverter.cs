namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Pie3DChartExtensionList Class.
/// </summary>
public static class Pie3DChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.Pie3DChartExtension> GetPie3DChartExtensions(DXDrawCharts.Pie3DChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.Pie3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.Pie3DChartExtension>())
    {
      var newItem = DMXDrawsCharts.Pie3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetPie3DChartExtensions(DXDrawCharts.Pie3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Pie3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.Pie3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.Pie3DChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.Pie3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.Pie3DChartExtensionList? CreateModelElement(DXDrawCharts.Pie3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Pie3DChartExtensionList();
      value.Pie3DChartExtensions = GetPie3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Pie3DChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.Pie3DChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPie3DChartExtensions(openXmlElement, value?.Pie3DChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
