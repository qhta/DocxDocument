namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public static class HyperlinkExtensionListConverter
{
  private static Collection<DMD.HyperlinkExtension>? GetHyperlinkExtensions(DXD.HyperlinkExtensionList openXmlElement)
  {
    var collection = new Collection<DMD.HyperlinkExtension>();
    foreach (var item in openXmlElement.Elements<DXD.HyperlinkExtension>())
    {
      var newItem = DMXD.HyperlinkExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpHyperlinkExtensions(DXD.HyperlinkExtensionList openXmlElement, Collection<DMD.HyperlinkExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXD.HyperlinkExtension>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXD.HyperlinkExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetHyperlinkExtensions(DXD.HyperlinkExtensionList openXmlElement, Collection<DMD.HyperlinkExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.HyperlinkExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.HyperlinkExtensionConverter.CreateOpenXmlElement<DXD.HyperlinkExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.HyperlinkExtensionList? CreateModelElement(DXD.HyperlinkExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HyperlinkExtensionList();
      value.HyperlinkExtensions = GetHyperlinkExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.HyperlinkExtensionList? openXmlElement, DMD.HyperlinkExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHyperlinkExtensions(openXmlElement, value.HyperlinkExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.HyperlinkExtensionList value)
    where OpenXmlElementType: DXD.HyperlinkExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.HyperlinkExtensionList openXmlElement, DMD.HyperlinkExtensionList value)
  {
    SetHyperlinkExtensions(openXmlElement, value?.HyperlinkExtensions);
  }
}
