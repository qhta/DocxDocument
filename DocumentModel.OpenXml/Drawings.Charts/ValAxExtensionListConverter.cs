namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ValAxExtensionList Class.
/// </summary>
public static class ValAxExtensionListConverter
{
  private static Collection<DMDrawsCharts.ValAxExtension>? GetValAxExtensions(DXDrawCharts.ValAxExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.ValAxExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.ValAxExtension>())
    {
      var newItem = DMXDrawsCharts.ValAxExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpValAxExtensions(DXDrawCharts.ValAxExtensionList openXmlElement, Collection<DMDrawsCharts.ValAxExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.ValAxExtension>();
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
        if (!DMXDrawsCharts.ValAxExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetValAxExtensions(DXDrawCharts.ValAxExtensionList openXmlElement, Collection<DMDrawsCharts.ValAxExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.ValAxExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.ValAxExtensionConverter.CreateOpenXmlElement<DXDrawCharts.ValAxExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ValAxExtensionList? CreateModelElement(DXDrawCharts.ValAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ValAxExtensionList();
      value.ValAxExtensions = GetValAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ValAxExtensionList? openXmlElement, DMDrawsCharts.ValAxExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpValAxExtensions(openXmlElement, value.ValAxExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ValAxExtensionList value)
    where OpenXmlElementType: DXDrawCharts.ValAxExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.ValAxExtensionList openXmlElement, DMDrawsCharts.ValAxExtensionList value)
  {
    SetValAxExtensions(openXmlElement, value?.ValAxExtensions);
  }
}
