namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SerAxExtensionList Class.
/// </summary>
public static class SerAxExtensionListConverter
{
  private static Collection<DMDrawsCharts.SerAxExtension>? GetSerAxExtensions(DXDrawCharts.SerAxExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.SerAxExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.SerAxExtension>())
    {
      var newItem = DMXDrawsCharts.SerAxExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSerAxExtensions(DXDrawCharts.SerAxExtensionList openXmlElement, Collection<DMDrawsCharts.SerAxExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.SerAxExtension>();
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
        if (!DMXDrawsCharts.SerAxExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSerAxExtensions(DXDrawCharts.SerAxExtensionList openXmlElement, Collection<DMDrawsCharts.SerAxExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.SerAxExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.SerAxExtensionConverter.CreateOpenXmlElement<DXDrawCharts.SerAxExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.SerAxExtensionList? CreateModelElement(DXDrawCharts.SerAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SerAxExtensionList();
      value.SerAxExtensions = GetSerAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.SerAxExtensionList? openXmlElement, DMDrawsCharts.SerAxExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSerAxExtensions(openXmlElement, value.SerAxExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SerAxExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.SerAxExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSerAxExtensions(openXmlElement, value?.SerAxExtensions);
      return openXmlElement;
    }
    return default;
  }
}
