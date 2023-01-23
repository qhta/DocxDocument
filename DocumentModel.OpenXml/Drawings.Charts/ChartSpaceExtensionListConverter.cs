namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartSpaceExtensionList Class.
/// </summary>
public static class ChartSpaceExtensionListConverter
{
  private static Collection<DMDrawsCharts.ChartSpaceExtension> GetChartSpaceExtensions(DXDrawCharts.ChartSpaceExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.ChartSpaceExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.ChartSpaceExtension>())
    {
      var newItem = DMXDrawsCharts.ChartSpaceExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpChartSpaceExtensions(DXDrawCharts.ChartSpaceExtensionList openXmlElement, Collection<DMDrawsCharts.ChartSpaceExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetChartSpaceExtensions(DXDrawCharts.ChartSpaceExtensionList openXmlElement, Collection<DMDrawsCharts.ChartSpaceExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.ChartSpaceExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.ChartSpaceExtensionConverter.CreateOpenXmlElement<DXDrawCharts.ChartSpaceExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.ChartSpaceExtensionList? CreateModelElement(DXDrawCharts.ChartSpaceExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ChartSpaceExtensionList();
      value.ChartSpaceExtensions = GetChartSpaceExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ChartSpaceExtensionList? openXmlElement, DMDrawsCharts.ChartSpaceExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChartSpaceExtensions(openXmlElement, value.ChartSpaceExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ChartSpaceExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.ChartSpaceExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartSpaceExtensions(openXmlElement, value?.ChartSpaceExtensions);
      return openXmlElement;
    }
    return default;
  }
}
