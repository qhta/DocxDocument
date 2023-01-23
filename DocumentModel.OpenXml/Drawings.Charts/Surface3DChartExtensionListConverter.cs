namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Surface3DChartExtensionList Class.
/// </summary>
public static class Surface3DChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.Surface3DChartExtension> GetSurface3DChartExtensions(DXDrawCharts.Surface3DChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.Surface3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.Surface3DChartExtension>())
    {
      var newItem = DMXDrawsCharts.Surface3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpSurface3DChartExtensions(DXDrawCharts.Surface3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Surface3DChartExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetSurface3DChartExtensions(DXDrawCharts.Surface3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Surface3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.Surface3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.Surface3DChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.Surface3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.Surface3DChartExtensionList? CreateModelElement(DXDrawCharts.Surface3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Surface3DChartExtensionList();
      value.Surface3DChartExtensions = GetSurface3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Surface3DChartExtensionList? openXmlElement, DMDrawsCharts.Surface3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSurface3DChartExtensions(openXmlElement, value.Surface3DChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Surface3DChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.Surface3DChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSurface3DChartExtensions(openXmlElement, value?.Surface3DChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
