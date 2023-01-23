namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BarChartExtensionList Class.
/// </summary>
public static class BarChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.BarChartExtension> GetBarChartExtensions(DXDrawCharts.BarChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BarChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BarChartExtension>())
    {
      var newItem = DMXDrawsCharts.BarChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpBarChartExtensions(DXDrawCharts.BarChartExtensionList openXmlElement, Collection<DMDrawsCharts.BarChartExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetBarChartExtensions(DXDrawCharts.BarChartExtensionList openXmlElement, Collection<DMDrawsCharts.BarChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.BarChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.BarChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.BarChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.BarChartExtensionList? CreateModelElement(DXDrawCharts.BarChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BarChartExtensionList();
      value.BarChartExtensions = GetBarChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.BarChartExtensionList? openXmlElement, DMDrawsCharts.BarChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBarChartExtensions(openXmlElement, value.BarChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BarChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.BarChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBarChartExtensions(openXmlElement, value?.BarChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
