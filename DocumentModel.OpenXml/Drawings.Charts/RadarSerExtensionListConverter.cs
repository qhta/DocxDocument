namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the RadarSerExtensionList Class.
/// </summary>
public static class RadarSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.RadarSerExtension>? GetRadarSerExtensions(DXDrawCharts.RadarSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.RadarSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.RadarSerExtension>())
    {
      var newItem = DMXDrawsCharts.RadarSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpRadarSerExtensions(DXDrawCharts.RadarSerExtensionList openXmlElement, Collection<DMDrawsCharts.RadarSerExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.RadarSerExtension>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDrawsCharts.RadarSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetRadarSerExtensions(DXDrawCharts.RadarSerExtensionList openXmlElement, Collection<DMDrawsCharts.RadarSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.RadarSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.RadarSerExtensionConverter.CreateOpenXmlElement<DXDrawCharts.RadarSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.RadarSerExtensionList? CreateModelElement(DXDrawCharts.RadarSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.RadarSerExtensionList();
      value.RadarSerExtensions = GetRadarSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.RadarSerExtensionList? openXmlElement, DMDrawsCharts.RadarSerExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRadarSerExtensions(openXmlElement, value.RadarSerExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.RadarSerExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.RadarSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadarSerExtensions(openXmlElement, value?.RadarSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}
