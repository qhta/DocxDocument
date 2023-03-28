namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Connection Sites converter from/to OpenXml.
///</summary>
public static class ConnectionSiteListConverter
{
  private static Collection<DMDraws.ConnectionSite>? GetConnectionSites(DXDraw.ConnectionSiteList openXmlElement)
  {
    var collection = new Collection<DMDraws.ConnectionSite>();
    foreach (var item in openXmlElement.Elements<DXDraw.ConnectionSite>())
    {
      var newItem = DMXDraws.ConnectionSiteConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpConnectionSites(DXDraw.ConnectionSiteList openXmlElement, Collection<DMDraws.ConnectionSite>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDraw.ConnectionSite>();
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
        if (!DMXDraws.ConnectionSiteConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetConnectionSites(DXDraw.ConnectionSiteList openXmlElement, Collection<DMDraws.ConnectionSite>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.ConnectionSite>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.ConnectionSiteConverter.CreateOpenXmlElement<DXDraw.ConnectionSite>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ConnectionSiteList? CreateModelElement(DXDraw.ConnectionSiteList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ConnectionSiteList();
      value.ConnectionSites = GetConnectionSites(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ConnectionSiteList? openXmlElement, DMDraws.ConnectionSiteList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpConnectionSites(openXmlElement, value.ConnectionSites, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ConnectionSiteList value)
    where OpenXmlElementType: DXDraw.ConnectionSiteList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.ConnectionSiteList openXmlElement, DMDraws.ConnectionSiteList value)
  {
    SetConnectionSites(openXmlElement, value?.ConnectionSites);
  }
}
