namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StrDataExtensionList Class.
/// </summary>
public static class StrDataExtensionListConverter
{
  private static Collection<DMDrawsCharts.StrDataExtension> GetStrDataExtensions(DXDrawCharts.StrDataExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.StrDataExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.StrDataExtension>())
    {
      var newItem = DMXDrawsCharts.StrDataExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpStrDataExtensions(DXDrawCharts.StrDataExtensionList openXmlElement, Collection<DMDrawsCharts.StrDataExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.StrDataExtension>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
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
  
  public static DMDrawsCharts.StrDataExtensionList? CreateModelElement(DXDrawCharts.StrDataExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.StrDataExtensionList();
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StrDataExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.StrDataExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStrDataExtensions(openXmlElement, value?.StrDataExtensions);
      return openXmlElement;
    }
    return default;
  }
}
