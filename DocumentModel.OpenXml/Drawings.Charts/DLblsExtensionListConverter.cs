namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DLblsExtensionList Class.
/// </summary>
public static class DLblsExtensionListConverter
{
  private static Collection<DMDrawsCharts.DLblsExtension>? GetDLblsExtensions(DXDrawCharts.DLblsExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.DLblsExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.DLblsExtension>())
    {
      var newItem = DMXDrawsCharts.DLblsExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDLblsExtensions(DXDrawCharts.DLblsExtensionList openXmlElement, Collection<DMDrawsCharts.DLblsExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.DLblsExtension>();
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
        if (!DMXDrawsCharts.DLblsExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDLblsExtensions(DXDrawCharts.DLblsExtensionList openXmlElement, Collection<DMDrawsCharts.DLblsExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.DLblsExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.DLblsExtensionConverter.CreateOpenXmlElement<DXDrawCharts.DLblsExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DLblsExtensionList? CreateModelElement(DXDrawCharts.DLblsExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DLblsExtensionList();
      value.DLblsExtensions = GetDLblsExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.DLblsExtensionList? openXmlElement, DMDrawsCharts.DLblsExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDLblsExtensions(openXmlElement, value.DLblsExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DLblsExtensionList value)
    where OpenXmlElementType: DXDrawCharts.DLblsExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.DLblsExtensionList openXmlElement, DMDrawsCharts.DLblsExtensionList value)
  {
    SetDLblsExtensions(openXmlElement, value?.DLblsExtensions);
  }
}
