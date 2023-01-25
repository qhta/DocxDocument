namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DLblsExtensionList Class.
/// </summary>
public static class DLblsExtensionListConverter
{
  private static Collection<DMDrawsCharts.DLblsExtension> GetDLblsExtensions(DXDrawCharts.DLblsExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.DLblsExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.DLblsExtension>())
    {
      var newItem = DMXDrawsCharts.DLblsExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpDLblsExtensions(DXDrawCharts.DLblsExtensionList openXmlElement, Collection<DMDrawsCharts.DLblsExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.DLblsExtension>();
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
        if (!DMXDrawsCharts.DLblsExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
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
  
  public static DMDrawsCharts.DLblsExtensionList? CreateModelElement(DXDrawCharts.DLblsExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DLblsExtensionList();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DLblsExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.DLblsExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDLblsExtensions(openXmlElement, value?.DLblsExtensions);
      return openXmlElement;
    }
    return default;
  }
}
