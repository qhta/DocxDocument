namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DateAxExtensionList Class.
/// </summary>
public static class DateAxExtensionListConverter
{
  private static Collection<DMDrawsCharts.DateAxExtension> GetDateAxExtensions(DXDrawCharts.DateAxExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.DateAxExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.DateAxExtension>())
    {
      var newItem = DMXDrawsCharts.DateAxExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpDateAxExtensions(DXDrawCharts.DateAxExtensionList openXmlElement, Collection<DMDrawsCharts.DateAxExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.DateAxExtension>();
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
        if (!DMXDrawsCharts.DateAxExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  private static void SetDateAxExtensions(DXDrawCharts.DateAxExtensionList openXmlElement, Collection<DMDrawsCharts.DateAxExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.DateAxExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.DateAxExtensionConverter.CreateOpenXmlElement<DXDrawCharts.DateAxExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.DateAxExtensionList? CreateModelElement(DXDrawCharts.DateAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DateAxExtensionList();
      value.DateAxExtensions = GetDateAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.DateAxExtensionList? openXmlElement, DMDrawsCharts.DateAxExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDateAxExtensions(openXmlElement, value.DateAxExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DateAxExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.DateAxExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDateAxExtensions(openXmlElement, value?.DateAxExtensions);
      return openXmlElement;
    }
    return default;
  }
}
