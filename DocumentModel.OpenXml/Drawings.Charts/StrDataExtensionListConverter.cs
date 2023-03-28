namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StrDataExtensionList Class converter from/to OpenXml.
///</summary>
public static class StrDataExtensionListConverter
{
  private static Collection<DMDrawsCharts.StrDataExtension>? GetStrDataExtensions(DXDrawCharts.StrDataExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.StrDataExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.StrDataExtension>())
    {
      var newItem = DMXDrawsCharts.StrDataExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpStrDataExtensions(DXDrawCharts.StrDataExtensionList openXmlElement, Collection<DMDrawsCharts.StrDataExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.StrDataExtension>();
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
        if (!DMXDrawsCharts.StrDataExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStrDataExtensions(DXDrawCharts.StrDataExtensionList openXmlElement, Collection<DMDrawsCharts.StrDataExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.StrDataExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.StrDataExtensionConverter.CreateOpenXmlElement<DXDrawCharts.StrDataExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.StrDataExtensionList? CreateModelElement(DXDrawCharts.StrDataExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StrDataExtensionList();
      value.StrDataExtensions = GetStrDataExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.StrDataExtensionList? openXmlElement, DMDrawsCharts.StrDataExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStrDataExtensions(openXmlElement, value.StrDataExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StrDataExtensionList value)
    where OpenXmlElementType: DXDrawCharts.StrDataExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.StrDataExtensionList openXmlElement, DMDrawsCharts.StrDataExtensionList value)
  {
    SetStrDataExtensions(openXmlElement, value?.StrDataExtensions);
  }
}
