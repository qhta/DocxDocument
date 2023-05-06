namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Connection Sites.
/// </summary>
public static class ConnectionSiteListConverter
{
  private static Collection<DMD.ConnectionSite>? GetConnectionSites(DXD.ConnectionSiteList openXmlElement)
  {
    var collection = new Collection<DMD.ConnectionSite>();
    foreach (var item in openXmlElement.Elements<DXD.ConnectionSite>())
    {
      var newItem = DMXD.ConnectionSiteConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpConnectionSites(DXD.ConnectionSiteList openXmlElement, Collection<DMD.ConnectionSite>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXD.ConnectionSite>();
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
        if (!DMXD.ConnectionSiteConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetConnectionSites(DXD.ConnectionSiteList openXmlElement, Collection<DMD.ConnectionSite>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.ConnectionSite>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.ConnectionSiteConverter.CreateOpenXmlElement<DXD.ConnectionSite>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ConnectionSiteList? CreateModelElement(DXD.ConnectionSiteList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ConnectionSiteList();
      value.ConnectionSites = GetConnectionSites(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.ConnectionSiteList? openXmlElement, DMD.ConnectionSiteList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ConnectionSiteList value)
    where OpenXmlElementType: DXD.ConnectionSiteList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ConnectionSiteList openXmlElement, DMD.ConnectionSiteList value)
  {
    SetConnectionSites(openXmlElement, value?.ConnectionSites);
  }
}
