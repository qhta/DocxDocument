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
  
  private static bool CmpScatterChartExtensions(DXDrawCharts.ScatterChartExtensionList openXmlElement, Collection<DMDrawsCharts.ScatterChartExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
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
  
  public static bool CompareModelElement(DXDrawCharts.ScatterChartExtensionList? openXmlElement, DMDrawsCharts.ScatterChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpScatterChartExtensions(openXmlElement, value.ScatterChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
