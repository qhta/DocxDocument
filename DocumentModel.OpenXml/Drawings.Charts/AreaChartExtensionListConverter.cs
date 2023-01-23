namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the AreaChartExtensionList Class.
/// </summary>
public static class AreaChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.AreaChartExtension> GetAreaChartExtensions(DXDrawCharts.AreaChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.AreaChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.AreaChartExtension>())
    {
      var newItem = DMXDrawsCharts.AreaChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpAreaChartExtensions(DXDrawCharts.AreaChartExtensionList openXmlElement, Collection<DMDrawsCharts.AreaChartExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetAreaChartExtensions(DXDrawCharts.AreaChartExtensionList openXmlElement, Collection<DMDrawsCharts.AreaChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.AreaChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.AreaChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.AreaChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.AreaChartExtensionList? CreateModelElement(DXDrawCharts.AreaChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.AreaChartExtensionList();
      value.AreaChartExtensions = GetAreaChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.AreaChartExtensionList? openXmlElement, DMDrawsCharts.AreaChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAreaChartExtensions(openXmlElement, value.AreaChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.AreaChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.AreaChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAreaChartExtensions(openXmlElement, value?.AreaChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
