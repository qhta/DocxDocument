namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DLblExtensionList Class.
/// </summary>
public static class DLblExtensionListConverter
{
  private static Collection<DMDrawsCharts.DLblExtension>? GetDLblExtensions(DXDrawCharts.DLblExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.DLblExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.DLblExtension>())
    {
      var newItem = DMXDrawsCharts.DLblExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDLblExtensions(DXDrawCharts.DLblExtensionList openXmlElement, Collection<DMDrawsCharts.DLblExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.DLblExtension>();
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
        if (!DMXDrawsCharts.DLblExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDLblExtensions(DXDrawCharts.DLblExtensionList openXmlElement, Collection<DMDrawsCharts.DLblExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.DLblExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.DLblExtensionConverter.CreateOpenXmlElement<DXDrawCharts.DLblExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DLblExtensionList? CreateModelElement(DXDrawCharts.DLblExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DLblExtensionList();
      value.DLblExtensions = GetDLblExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.DLblExtensionList? openXmlElement, DMDrawsCharts.DLblExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDLblExtensions(openXmlElement, value.DLblExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DLblExtensionList value)
    where OpenXmlElementType: DXDrawCharts.DLblExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.DLblExtensionList openXmlElement, DMDrawsCharts.DLblExtensionList value)
  {
    SetDLblExtensions(openXmlElement, value?.DLblExtensions);
  }
}
