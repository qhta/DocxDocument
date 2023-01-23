namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the RadarChartExtensionList Class.
/// </summary>
public static class RadarChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.RadarChartExtension> GetRadarChartExtensions(DXDrawCharts.RadarChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.RadarChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.RadarChartExtension>())
    {
      var newItem = DMXDrawsCharts.RadarChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpRadarChartExtensions(DXDrawCharts.RadarChartExtensionList openXmlElement, Collection<DMDrawsCharts.RadarChartExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetRadarChartExtensions(DXDrawCharts.RadarChartExtensionList openXmlElement, Collection<DMDrawsCharts.RadarChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.RadarChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.RadarChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.RadarChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.RadarChartExtensionList? CreateModelElement(DXDrawCharts.RadarChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.RadarChartExtensionList();
      value.RadarChartExtensions = GetRadarChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.RadarChartExtensionList? openXmlElement, DMDrawsCharts.RadarChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRadarChartExtensions(openXmlElement, value.RadarChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.RadarChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.RadarChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadarChartExtensions(openXmlElement, value?.RadarChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
