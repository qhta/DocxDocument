namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the AreaSerExtensionList Class converter from/to OpenXml.
///</summary>
public static class AreaSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.AreaSerExtension>? GetAreaSerExtensions(DXDrawCharts.AreaSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.AreaSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.AreaSerExtension>())
    {
      var newItem = DMXDrawsCharts.AreaSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAreaSerExtensions(DXDrawCharts.AreaSerExtensionList openXmlElement, Collection<DMDrawsCharts.AreaSerExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.AreaSerExtension>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
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
        if (!DMXDrawsCharts.AreaSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAreaSerExtensions(DXDrawCharts.AreaSerExtensionList openXmlElement, Collection<DMDrawsCharts.AreaSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.AreaSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.AreaSerExtensionConverter.CreateOpenXmlElement<DXDrawCharts.AreaSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.AreaSerExtensionList? CreateModelElement(DXDrawCharts.AreaSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.AreaSerExtensionList();
      value.AreaSerExtensions = GetAreaSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.AreaSerExtensionList? openXmlElement, DMDrawsCharts.AreaSerExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAreaSerExtensions(openXmlElement, value.AreaSerExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.AreaSerExtensionList value)
    where OpenXmlElementType: DXDrawCharts.AreaSerExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.AreaSerExtensionList openXmlElement, DMDrawsCharts.AreaSerExtensionList value)
  {
    SetAreaSerExtensions(openXmlElement, value?.AreaSerExtensions);
  }
}
