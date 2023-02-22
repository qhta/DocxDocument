namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CatAxExtensionList Class.
/// </summary>
public static class CatAxExtensionListConverter
{
  private static Collection<DMDrawsCharts.CatAxExtension>? GetCatAxExtensions(DXDrawCharts.CatAxExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.CatAxExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.CatAxExtension>())
    {
      var newItem = DMXDrawsCharts.CatAxExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpCatAxExtensions(DXDrawCharts.CatAxExtensionList openXmlElement, Collection<DMDrawsCharts.CatAxExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.CatAxExtension>();
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
        if (!DMXDrawsCharts.CatAxExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetCatAxExtensions(DXDrawCharts.CatAxExtensionList openXmlElement, Collection<DMDrawsCharts.CatAxExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.CatAxExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.CatAxExtensionConverter.CreateOpenXmlElement<DXDrawCharts.CatAxExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.CatAxExtensionList? CreateModelElement(DXDrawCharts.CatAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CatAxExtensionList();
      value.CatAxExtensions = GetCatAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.CatAxExtensionList? openXmlElement, DMDrawsCharts.CatAxExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCatAxExtensions(openXmlElement, value.CatAxExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.CatAxExtensionList value)
    where OpenXmlElementType: DXDrawCharts.CatAxExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.CatAxExtensionList openXmlElement, DMDrawsCharts.CatAxExtensionList value)
  {
    SetCatAxExtensions(openXmlElement, value?.CatAxExtensions);
    }
  }
