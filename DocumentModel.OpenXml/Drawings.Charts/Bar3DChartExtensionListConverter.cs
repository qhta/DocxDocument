namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Bar3DChartExtensionList Class.
/// </summary>
public static class Bar3DChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.Bar3DChartExtension> GetBar3DChartExtensions(DXDrawCharts.Bar3DChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.Bar3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.Bar3DChartExtension>())
    {
      var newItem = DMXDrawsCharts.Bar3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpBar3DChartExtensions(DXDrawCharts.Bar3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Bar3DChartExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetBar3DChartExtensions(DXDrawCharts.Bar3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Bar3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.Bar3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.Bar3DChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.Bar3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.Bar3DChartExtensionList? CreateModelElement(DXDrawCharts.Bar3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Bar3DChartExtensionList();
      value.Bar3DChartExtensions = GetBar3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Bar3DChartExtensionList? openXmlElement, DMDrawsCharts.Bar3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBar3DChartExtensions(openXmlElement, value.Bar3DChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Bar3DChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.Bar3DChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBar3DChartExtensions(openXmlElement, value?.Bar3DChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
