namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public static class HyperlinkExtensionListConverter
{
  private static Collection<DMDraws.HyperlinkExtension>? GetHyperlinkExtensions(DXDraw.HyperlinkExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.HyperlinkExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.HyperlinkExtension>())
    {
      var newItem = DMXDraws.HyperlinkExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpHyperlinkExtensions(DXDraw.HyperlinkExtensionList openXmlElement, Collection<DMDraws.HyperlinkExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDraw.HyperlinkExtension>();
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
        if (!DMXDraws.HyperlinkExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetHyperlinkExtensions(DXDraw.HyperlinkExtensionList openXmlElement, Collection<DMDraws.HyperlinkExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.HyperlinkExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.HyperlinkExtensionConverter.CreateOpenXmlElement<DXDraw.HyperlinkExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.HyperlinkExtensionList? CreateModelElement(DXDraw.HyperlinkExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HyperlinkExtensionList();
      value.HyperlinkExtensions = GetHyperlinkExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.HyperlinkExtensionList? openXmlElement, DMDraws.HyperlinkExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHyperlinkExtensions(openXmlElement, value.HyperlinkExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.HyperlinkExtensionList? value)
    where OpenXmlElementType: DXDraw.HyperlinkExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHyperlinkExtensions(openXmlElement, value?.HyperlinkExtensions);
      return openXmlElement;
    }
    return default;
  }
}
