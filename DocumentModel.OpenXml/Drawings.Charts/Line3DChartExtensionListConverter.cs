namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Line3DChartExtensionList Class.
/// </summary>
public static class Line3DChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.Line3DChartExtension> GetLine3DChartExtensions(DXDrawCharts.Line3DChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.Line3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.Line3DChartExtension>())
    {
      var newItem = DMXDrawsCharts.Line3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpLine3DChartExtensions(DXDrawCharts.Line3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Line3DChartExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetLine3DChartExtensions(DXDrawCharts.Line3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Line3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.Line3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.Line3DChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.Line3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.Line3DChartExtensionList? CreateModelElement(DXDrawCharts.Line3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Line3DChartExtensionList();
      value.Line3DChartExtensions = GetLine3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Line3DChartExtensionList? openXmlElement, DMDrawsCharts.Line3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLine3DChartExtensions(openXmlElement, value.Line3DChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Line3DChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.Line3DChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLine3DChartExtensions(openXmlElement, value?.Line3DChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
